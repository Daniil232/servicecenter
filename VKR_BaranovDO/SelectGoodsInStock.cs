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
    public partial class SelectGoodsInStock : Form
    {
        public int IdTovar { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameTovar { get; set; } = "";
        public int IdWarehouse { get; set; } = -1;
        public int PriceRepair { get; set; } = -1;
        public int PriceRetail { get; set; } = -1;
        public int IdGoodsInStock { get; set; } = -1;
        public bool IsMoving { get; set; } = false;

        public SelectGoodsInStock()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewGoods.SelectedRows.Count > 0)
            {
                IdGoodsInStock = Convert.ToInt32(dataGridViewGoods.SelectedRows[0].Cells["Номер записи"].Value);
                IdTovar = Convert.ToInt32(dataGridViewGoods.SelectedRows[0].Cells["Номер товара"].Value);
                NameTovar = Convert.ToString(dataGridViewGoods.SelectedRows[0].Cells["Наименование"].Value);
                PriceRepair = Convert.ToInt32(dataGridViewGoods.SelectedRows[0].Cells["Цена ремонтная"].Value);
                PriceRetail = Convert.ToInt32(dataGridViewGoods.SelectedRows[0].Cells["Цена розничная"].Value);
                IsSelected = true;
                this.Close();
            }
        }

        private void SelectGoodsInStock_Load(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT * FROM `goodsinstockservice`");
            if (IdWarehouse != 0)
            {
                com = new MySqlCommand("SELECT * FROM `goodsinstockservice` WHERE `Номер склада` = @Warehouse;");
                com.Parameters.AddWithValue("@Warehouse", IdWarehouse);
            }             
            dataGridViewGoods.DataSource = Program.Database.Query(com);
            dataGridViewGoods.Columns["Номер записи"].Visible = false;
            dataGridViewGoods.Columns["Номер товара"].Visible = false;
            dataGridViewGoods.Columns["Номер склада"].Visible = false;
        }

        private void textBoxSeach_TextChanged(object sender, EventArgs e)
        {
                var com = new MySqlCommand("SELECT * FROM `goodsinstockservice` WHERE `Наименование` LIKE @Name AND `Номер склада` = @Warehouse");
                com.Parameters.AddWithValue("@Name", "%" + textBoxSeach.Text + "%");
                com.Parameters.AddWithValue("@Warehouse", IdWarehouse);
                dataGridViewGoods.DataSource = Program.Database.Query(com);     
        }
    }
}
