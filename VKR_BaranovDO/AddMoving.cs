using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR_BaranovDO
{
    public partial class AddMoving : Form
    {
        public bool IsAdded { get; set; } = false;
        private int idTovar = -1;
        private int Count = -1;
        private int idGoods = -1;
        private string NameTovar = "";
        private int Retail = -1;
        private int Repair = -1;

        public AddMoving()
        {
            InitializeComponent();
        }

        private void AddMoving_Load(object sender, EventArgs e)
        {
            comboBoxWarehouseFrom.DataSource = Program.Database.Query("SELECT * FROM servicecenter.warehouse");
            comboBoxWarehouseFrom.ValueMember = "idWarehouse";
            comboBoxWarehouseFrom.DisplayMember = "Name";

            comboBoxWarehouseInto.DataSource = Program.Database.Query("SELECT * FROM servicecenter.warehouse");
            comboBoxWarehouseInto.ValueMember = "idWarehouse";
            comboBoxWarehouseInto.DisplayMember = "Name";
            comboBoxWarehouseInto.SelectedIndex = comboBoxWarehouseFrom.SelectedIndex + 1;

            dataGridViewMoving.Columns.Add("Номер", "Номер");
            dataGridViewMoving.Columns.Add("Наименование", "Наименование");
            dataGridViewMoving.Columns.Add("Кол-во", "Кол-во");
            dataGridViewMoving.Columns.Add("Цена ремонтная", "Цена ремонтная");
            dataGridViewMoving.Columns.Add("Цена розничная", "Цена розничная");
            dataGridViewMoving.Columns.Add("Номер товара", "Номер товара");

            dataGridViewMoving.Columns["Номер"].Visible = false;
            dataGridViewMoving.Columns["Цена ремонтная"].Visible = false;
            dataGridViewMoving.Columns["Цена розничная"].Visible = false;
            dataGridViewMoving.Columns["Номер товара"].Visible = false;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectGoodsInStock s = new SelectGoodsInStock();
            s.IdWarehouse = (int)comboBoxWarehouseFrom.SelectedValue;
            s.ShowDialog();

            if (s.IsSelected)
            {
                idGoods = s.IdGoodsInStock;
                idTovar = s.IdTovar;
                NameTovar = s.NameTovar;
                Repair = s.PriceRepair;
                Retail = s.PriceRetail;
                textBoxTovar.Text = NameTovar;
            }
        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            if (textBoxTovar.Text != "")
            {
                SelectCountTovar s = new SelectCountTovar();
                s.IdGoods = idGoods;
                s.NameTovar = NameTovar;
                s.ShowDialog();
   
                if (s.IsSelected)
                {
                    Count = s.Count;
                    var flag = false;
                    foreach (DataGridViewRow row in dataGridViewMoving.Rows)
                    {
                        if ((int)row.Cells["Номер"].Value == idGoods)
                        {
                            row.Cells["Кол-во"].Value = s.Count;
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        dataGridViewMoving.Rows.Add(idGoods, NameTovar, s.Count, Repair, Retail, idTovar);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали товар!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewMoving.Rows.Count == 0 || comboBoxWarehouseFrom.SelectedValue == comboBoxWarehouseInto.SelectedValue)
            {
                MessageBox.Show("Таблица пуста или вы перемещаете товар в тот же склад!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                AddMovingDB();
                foreach (DataGridViewRow row in dataGridViewMoving.Rows)
                {
                    AddTovMoving(row);
                    EditGoodsInStockMinus(row);
                    CheckGoodsWarehouse(row);
                }
                IsAdded = true;
                this.Close();
                MessageBox.Show("Перемещение добавлено!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddMovingDB()
        {
            var com = new MySqlCommand("CALL AddMoving(@DateMoving, @Employee, @FromWarehouse, @IntoWarehouse)");
            com.Parameters.AddWithValue("@DateMoving", DateTime.Now);
            com.Parameters.AddWithValue("@Employee", Program.User.NameUser);
            com.Parameters.AddWithValue("@FromWarehouse", comboBoxWarehouseFrom.SelectedValue);
            com.Parameters.AddWithValue("@IntoWarehouse", comboBoxWarehouseInto.SelectedValue);
            Program.Database.Query(com);
        }

        public void AddTovMoving(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT idMoving FROM moving WHERE idMoving=(SELECT max(`idMoving`) FROM moving)");
            var data = Program.Database.Query(com);
            var lastId = Int32.Parse(data.Rows[0]["idMoving"].ToString());

            com = new MySqlCommand("CALL AddTovMoving(@MovingId, @TovarId, @Count)");
            com.Parameters.AddWithValue("@MovingId", lastId);
            com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
            com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
            Program.Database.Query(com);
        }

        public void EditGoodsInStockMinus(DataGridViewRow row)
        {
            var com = new MySqlCommand("CALL EditGoodsInStockMinus(@Count, @GoodsInStockId)");
            com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
            com.Parameters.AddWithValue("@GoodsInStockId", (int)row.Cells["Номер"].Value);
            Program.Database.Query(com);
        }

        public void CheckGoodsWarehouse(DataGridViewRow row)
        {
            var com = new MySqlCommand("CALL FindGoodsInStock(@TovarId, @WarehouseId, @Repair, @Retail)");
            com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
            com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouseInto.SelectedValue);
            com.Parameters.AddWithValue("@Repair", (int)row.Cells["Цена ремонтная"].Value);
            com.Parameters.AddWithValue("@Retail", (int)row.Cells["Цена розничная"].Value);
            var data = Program.Database.Query(com);
            if (data.Rows.Count == 0)
            {
                com = new MySqlCommand("CALL AddGoodsInStock(@TovarId, @NCount, @WarehouseId, @PriceRepair, @PriceRetail)");
                com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
                com.Parameters.AddWithValue("@NCount", (int)row.Cells["Кол-во"].Value);
                com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouseInto.SelectedValue);
                com.Parameters.AddWithValue("@PriceRepair", (int)row.Cells["Цена ремонтная"].Value);
                com.Parameters.AddWithValue("@PriceRetail", (int)row.Cells["Цена розничная"].Value);
                Program.Database.Query(com);
            }
            else
            {
                var idGoods = Int32.Parse(data.Rows[0]["idGoodsinstock"].ToString());
                com = new MySqlCommand("CALL EditGoodsInStockPlus(@NCount, @GoodsInStockId)");
                com.Parameters.AddWithValue("@NCount", (int)row.Cells["Кол-во"].Value);
                com.Parameters.AddWithValue("@GoodsInStockId", idGoods);
                Program.Database.Query(com);

            }
        }

        private void comboBoxWarehouseFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTovar.Text = "";
            dataGridViewMoving.Rows.Clear();
            dataGridViewMoving.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMoving.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int i = dataGridViewMoving.CurrentRow.Index;
                        dataGridViewMoving.Rows.RemoveAt(i);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
