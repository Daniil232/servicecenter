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
    public partial class AddPosting : Form
    {
        public bool IsAdded { get; set; } = false;
        private int idTovar = -1;
        private string NameTovar = "";
        public AddPosting()
        {
            InitializeComponent();
            Initialize();

            dataGridViewTovars.Columns.Add("Номер товара", "Номер товара");
            dataGridViewTovars.Columns.Add("Наименование", "Наименование");
            dataGridViewTovars.Columns.Add("Кол-во", "Кол-во");
            dataGridViewTovars.Columns.Add("Цена", "Цена");
            dataGridViewTovars.Columns.Add("Сумма", "Сумма");
            dataGridViewTovars.Columns.Add("Цена ремонтная", "Цена ремонтная");
            dataGridViewTovars.Columns.Add("Цена розничная", "Цена розничная");

        }
        void Initialize()
        {
            comboBoxSupplier.DataSource = Program.Database.Query("SELECT * FROM servicecenter.supplier;");
            comboBoxSupplier.ValueMember = "idSupplier";
            comboBoxSupplier.DisplayMember = "Name";

            comboBoxWarehouse.DataSource = Program.Database.Query("SELECT * FROM servicecenter.warehouse;");
            comboBoxWarehouse.ValueMember = "idWarehouse";
            comboBoxWarehouse.DisplayMember = "Name";
        }

        public void RefreshTotal()
        {
            var total = 0;
            var price = 0;
            var count = 0;
            foreach (DataGridViewRow row in dataGridViewTovars.Rows)
            {
                if (row.Cells["Кол-во"].Value != null)
                    count = (int)row.Cells["Кол-во"].Value;
                if (row.Cells["Цена"].Value != null)
                    price = (int)row.Cells["Цена"].Value;
                total += count * price;
            }

            LabelTotal.Text = total.ToString();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddClient addSupplier = new AddClient();
            addSupplier.checkBoxSupplier.Checked = true;
            addSupplier.ShowDialog();
            if (addSupplier.IsAdded)
                Initialize();
        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            SelectTovar s = new SelectTovar();
            s.ShowDialog();

            if (s.IsSelected)
            {
                idTovar = s.IdTovar;
                NameTovar = s.NameTovar;
                textBoxTovar.Text = NameTovar;
            }
        }

        private void buttonAddTovar_Click_1(object sender, EventArgs e)
        {
            if (textBoxTovar.Text != "")
            {
                SelectCountAndPrice s = new SelectCountAndPrice();
                s.IdTovar = idTovar;
                s.NameTovar = NameTovar;
                s.ShowDialog();

                if (s.IsSelected)
                {
                    dataGridViewTovars.Rows.Add(s.IdTovar, s.NameTovar, s.Count, s.Price, s.Count * s.Price, (int)s.Repair, (int)s.Retail);
                    RefreshTotal();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали товар!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonPosting_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovars.Rows.Count == 0 || 
                textBoxWaybill.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                AddPostingDB();
                foreach (DataGridViewRow row in dataGridViewTovars.Rows)
                {
                    AddGoodsInStock(row);
                    EditWaitingMinus(row);
                }
                DeleteWaiting();

                IsAdded = true;
                this.Close();

                MessageBox.Show("Оприходование добавлено!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void AddPostingDB()
        {
            var com = new MySqlCommand("CALL AddPosting(@SupplierId, @Waybill, @DateWaybill, @WarehouseId, @Totalprice, @EmployeeName)");
            com.Parameters.AddWithValue("@SupplierId", comboBoxSupplier.SelectedValue);
            com.Parameters.AddWithValue("@Waybill", textBoxWaybill.Text);
            com.Parameters.AddWithValue("@DateWaybill", dateTimePickerWaybill.Value);
            com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouse.SelectedValue);
            com.Parameters.AddWithValue("@Totalprice", LabelTotal.Text);
            com.Parameters.AddWithValue("@EmployeeName", Program.User.NameUser);
            Program.Database.Query(com);
        }

        public void AddTovPosting(DataGridViewRow row, int idgoods)
        {
            var com = new MySqlCommand("SELECT idPosting FROM posting WHERE idPosting=(SELECT max(`idPosting`) FROM posting)");
            var data = Program.Database.Query(com);
            var lastId = Int32.Parse(data.Rows[0]["idPosting"].ToString());

            com = new MySqlCommand("CALL AddTovPosting(@PostingId, @GoodsId, @Count, @Price)");
            com.Parameters.AddWithValue("@PostingId", lastId);
            com.Parameters.AddWithValue("@GoodsId", idgoods);
            com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
            com.Parameters.AddWithValue("@Price", (int)row.Cells["Цена"].Value);
            Program.Database.Query(com);
        }

        public void AddGoodsInStock(DataGridViewRow row)
        {
            var com = new MySqlCommand("CALL FindGoodsInStock(@TovarId, @WarehouseId, @Repair, @Retail)");
            com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
            com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouse.SelectedValue);
            com.Parameters.AddWithValue("@Repair", (int)row.Cells["Цена ремонтная"].Value);
            com.Parameters.AddWithValue("@Retail", (int)row.Cells["Цена розничная"].Value);
            var data = Program.Database.Query(com);
            if (data.Rows.Count == 0)
            {
                com = new MySqlCommand("CALL AddGoodsInStock(@TovarId, @NCount, @WarehouseId, @PriceRepair, @PriceRetail)");
                com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
                com.Parameters.AddWithValue("@NCount", (int)row.Cells["Кол-во"].Value);
                com.Parameters.AddWithValue("@WarehouseId", comboBoxWarehouse.SelectedValue);
                com.Parameters.AddWithValue("@PriceRepair", (int)row.Cells["Цена ремонтная"].Value);
                com.Parameters.AddWithValue("@PriceRetail", (int)row.Cells["Цена розничная"].Value);
                Program.Database.Query(com);
                var idGoods = Program.Database.Query("SELECT idGoodsinstock FROM goodsinstock WHERE `idGoodsinstock`=(SELECT max(`idGoodsinstock`) FROM goodsinstock)");
                AddTovPosting(row, Int32.Parse(idGoods.Rows[0]["idGoodsinstock"].ToString()));
            }
            else
            {
                var idGoods = Int32.Parse(data.Rows[0]["idGoodsinstock"].ToString());
                com = new MySqlCommand("CALL EditGoodsInStockPlus(@NCount, @GoodsInStockId)");
                com.Parameters.AddWithValue("@NCount", (int)row.Cells["Кол-во"].Value);
                com.Parameters.AddWithValue("@GoodsInStockId", idGoods);
                Program.Database.Query(com);
                AddTovPosting(row, idGoods);
            }
        }

        public void DeleteWaiting()
        {
            dataGridViewTemp.DataSource = Program.Database.Query("SELECT * FROM `waitingtovar`");
            foreach (DataGridViewRow row in dataGridViewTemp.Rows)
            {
                if ((int)row.Cells["Count"].Value == 0)
                {
                    var com = new MySqlCommand("CALL DeleteWaiting(@WaitingId)");
                    com.Parameters.AddWithValue("@WaitingId", (int)row.Cells["idWaiting"].Value);
                    Program.Database.Query(com);
                }
            }
        }

        public void EditWaitingMinus(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT * FROM `waitingtovar` WHERE TovarId = @TovarId");
            com.Parameters.AddWithValue("@TovarId", (int)row.Cells["Номер товара"].Value);
            dataGridViewTemp.DataSource = Program.Database.Query(com);

            if (dataGridViewTemp.Rows.Count != 0)
            {
                var j = (int)row.Cells["Кол-во"].Value;
                foreach (DataGridViewRow row1 in dataGridViewTemp.Rows)
                {
                    if ((int)row1.Cells["Count"].Value > j)
                    {
                        for (int i = 0; i < j; i++)
                        {
                            var com1 = new MySqlCommand("CALL EditWaitingMinusOne(@WaitingId)");
                            com1.Parameters.AddWithValue("@WaitingId", (int)row1.Cells["idWaiting"].Value);
                            Program.Database.Query(com1);
                        }
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < (int)row1.Cells["Count"].Value; i++)
                        {
                            var com2 = new MySqlCommand("CALL EditWaitingMinusOne(@WaitingId)");
                            com2.Parameters.AddWithValue("@WaitingId", (int)row1.Cells["idWaiting"].Value);
                            Program.Database.Query(com2);
                        }

                        j -= (int)row1.Cells["Count"].Value;
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovars.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int i = dataGridViewTovars.CurrentRow.Index;
                        dataGridViewTovars.Rows.RemoveAt(i);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddPosting_Load(object sender, EventArgs e)
        {

        }
    }
}
