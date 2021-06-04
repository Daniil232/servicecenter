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
    public partial class AddTovars : Form
    {
        public bool IsAdded { get; set; } = false;
        private int idTovar = -1;
        private int idGoods = -1;
        public int idOrder { get; set; } = -1;
        private string nameTovar = "";
        private int priceRepair = -1;
        private int priceRetail = -1;
        public AddTovars()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectGoodsInStock s = new SelectGoodsInStock();
            if (comboBoxWarehouse.Text == "Все склады")
                s.IdWarehouse = 0;
            else
                s.IdWarehouse = (int)comboBoxWarehouse.SelectedValue;
            s.ShowDialog();

            if (s.IsSelected)
            {
                idGoods = s.IdGoodsInStock;
                idTovar = s.IdTovar;
                nameTovar = s.NameTovar;
                priceRetail = s.PriceRetail;
                priceRepair = s.PriceRepair;
                textBoxTovar.Text = nameTovar;
            }
        }

        private void AddTovars_Load(object sender, EventArgs e)
        {
            dataGridViewTovars.Columns.Add("Номер записи", "Номер записи");
            dataGridViewTovars.Columns.Add("Номер товара", "Номер товара");
            dataGridViewTovars.Columns.Add("Наименование", "Наименование");
            dataGridViewTovars.Columns.Add("Кол-во", "Кол-во");
            dataGridViewTovars.Columns.Add("Цена", "Цена");
            dataGridViewTovars.Columns.Add("Сумма", "Сумма");

            dataGridViewTovars.Columns["Номер записи"].Visible = false;
            dataGridViewTovars.Columns["Номер товара"].Visible = false;

            comboBoxPrice.Text = "Ремонтная";

            var data = Program.Database.Query("SELECT * FROM warehouse");
            data.Rows.Add(null, "Все склады");
            comboBoxWarehouse.DataSource = data;
            comboBoxWarehouse.DisplayMember = "Name";
            comboBoxWarehouse.ValueMember = "idWarehouse";
            comboBoxWarehouse.SelectedIndex = comboBoxWarehouse.Items.Count - 1;

        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            if (textBoxTovar.Text != "")
            {
                SelectCountTovar s = new SelectCountTovar();
                s.IdGoods = idGoods;
                s.NameTovar = nameTovar;
                s.ShowDialog();

                if (s.IsSelected)
                {
                    var flag = false;
                    foreach (DataGridViewRow row in dataGridViewTovars.Rows)
                    {
                        if ((int)row.Cells["Номер записи"].Value == idGoods)
                        { 
                            row.Cells["Кол-во"].Value = s.Count;
                            if (comboBoxPrice.Text == "Ремонтная")
                            {
                                row.Cells["Цена"].Value = priceRepair;
                            }
                            else
                            {
                                row.Cells["Цена"].Value = priceRetail;
                            }
                            row.Cells["Сумма"].Value = s.Count * (int)row.Cells["Цена"].Value;
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        if (comboBoxPrice.Text == "Ремонтная")
                            dataGridViewTovars.Rows.Add(idGoods, idTovar, nameTovar, s.Count, priceRepair, s.Count * priceRepair);
                        else
                            dataGridViewTovars.Rows.Add(idGoods, idTovar, nameTovar, s.Count, priceRetail, s.Count * priceRetail);
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали товар!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonWriteOff_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovars.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewTovars.Rows)
                {
                    var com = new MySqlCommand("SELECT * FROM goodsinstock WHERE idGoodsinstock = @GoodsId");
                    com.Parameters.AddWithValue("@GoodsId", (int)row.Cells["Номер записи"].Value);
                    var table = Program.Database.Query(com);
                    idGoods = Int32.Parse(table.Rows[0]["idGoodsinstock"].ToString());
          


                    com = new MySqlCommand("CALL EditGoodsInStockMinus(@Count, @GoodsInStockId)");
                    com.Parameters.AddWithValue("@Count", (int)row.Cells["Кол-во"].Value);
                    com.Parameters.AddWithValue("@GoodsInStockId", idGoods);
                    Program.Database.Query(com);

                    com = new MySqlCommand("CALL AddCompletedWork(@OrderId, @Name, @Price, @Count, @GoodsId)");
                    com.Parameters.AddWithValue("@OrderId", idOrder);
                    com.Parameters.AddWithValue("@Name", row.Cells["Наименование"].Value);
                    com.Parameters.AddWithValue("@Price", row.Cells["Цена"].Value);
                    com.Parameters.AddWithValue("@Count", row.Cells["Кол-во"].Value);
                    com.Parameters.AddWithValue("@GoodsId", idGoods);
                    Program.Database.Query(com);
                }

                IsAdded = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали ниодного товара!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
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
                        var deleteId = (int)dataGridViewTovars.CurrentRow.Index;
                        dataGridViewTovars.Rows.RemoveAt(deleteId);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTovar.Text = "";
        }
    }
}
