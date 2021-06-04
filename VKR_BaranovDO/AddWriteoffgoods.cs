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
    public partial class AddWriteoffgoods : Form
    {
        public bool IsAdded { get; set; } = false;
        private int Count = -1;
        private int idGoods = -1;
        private int idTovar = -1;
        private string NameTovar = "";

        public AddWriteoffgoods()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectGoodsInStock s = new SelectGoodsInStock();
            s.IdWarehouse = (int)comboBoxWarehouse.SelectedValue;
            s.ShowDialog();

            if (s.IsSelected)
            {
                idGoods = s.IdGoodsInStock;
                idTovar = s.IdTovar;
                NameTovar = s.NameTovar;
                textBoxTovar.Text = NameTovar;
            }
        }

        private void AddWriteoffgoods_Load(object sender, EventArgs e)
        {
            comboBoxWarehouse.DataSource = Program.Database.Query("SELECT * FROM servicecenter.warehouse");
            comboBoxWarehouse.ValueMember = "idWarehouse";
            comboBoxWarehouse.DisplayMember = "Name";

            dataGridViewWriteoff.Columns.Add("Номер", "Номер");
            dataGridViewWriteoff.Columns.Add("Наименование", "Наименование");
            dataGridViewWriteoff.Columns.Add("Кол-во", "Кол-во");
            dataGridViewWriteoff.Columns.Add("Номер товара", "Номер товара");

            dataGridViewWriteoff.Columns["Номер"].Visible = false;
            dataGridViewWriteoff.Columns["Номер товара"].Visible = false;
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
                    foreach (DataGridViewRow row in dataGridViewWriteoff.Rows)
                    {
                        if ((int)row.Cells["Номер"].Value == idGoods)
                        {
                            row.Cells["Кол-во"].Value = s.Count;
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        dataGridViewWriteoff.Rows.Add(idGoods, NameTovar, s.Count, idTovar);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали товар!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTovar.Text = "";
            dataGridViewWriteoff.Rows.Clear();
            dataGridViewWriteoff.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewWriteoff.Rows.Count != 0)
            {
                AddMovingDB();
                foreach (DataGridViewRow row in dataGridViewWriteoff.Rows)
                {
                    AddTovWriting(row);
                    EditGoodsInStockMinus(row);
                }
                IsAdded = true;
                this.Close();
                MessageBox.Show("Списание добавлено!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы не выбрали ниодного товара!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        public void EditGoodsInStockMinus(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT * FROM goodsinstock WHERE idGoodsinstock = @GoodsId");
            com.Parameters.AddWithValue("@GoodsId", (int)row.Cells["Номер"].Value);
            var data = Program.Database.Query(com);
            idGoods = Int32.Parse(data.Rows[0]["idGoodsinstock"].ToString());

            com = new MySqlCommand("CALL EditGoodsInStockMinus(@Count, @GoodsInStockId)");
            com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
            com.Parameters.AddWithValue("@GoodsInStockId", idGoods);
            Program.Database.Query(com);
        }

        public void AddMovingDB()
        {
            var com = new MySqlCommand("CALL AddWriteoffgoods(@DateWriting, @Employee, @WarehouseId)");
            com.Parameters.AddWithValue("@DateWriting", DateTime.Now);
            com.Parameters.AddWithValue("@Employee", Program.User.NameUser);
            com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouse.SelectedValue);
            Program.Database.Query(com);
        }

        public void AddTovWriting(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT idWriteoffgoods FROM writeoffgoods WHERE idWriteoffgoods=(SELECT max(`idWriteoffgoods`) FROM writeoffgoods)");
            var data = Program.Database.Query(com);
            var lastId = Int32.Parse(data.Rows[0]["idWriteoffgoods"].ToString());

            com = new MySqlCommand("CALL AddTovWriting(@WriteoffgoodsId, @TovarId, @Count)");
            com.Parameters.AddWithValue("@WriteoffgoodsId", lastId);
            com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
            com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
            Program.Database.Query(com);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWriteoff.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int i = dataGridViewWriteoff.CurrentRow.Index;
                        dataGridViewWriteoff.Rows.RemoveAt(i);
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
