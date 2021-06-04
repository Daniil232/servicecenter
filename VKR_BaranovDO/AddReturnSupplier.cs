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
    public partial class AddReturnSupplier : Form
    {
        public string NamePosting { get; set; } = "";
        public bool IsAdded { get; set; } = false;
        public int idPosting { get; set; } = -1;
        public string NameSupplier { get; set; } = "";
        public string DatePosting { get; set; } = "";
        public string NameWarehouse { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        private int Price { get; set; } = 0;
        private int Count { get; set; } = 0;
        public AddReturnSupplier()
        {
            InitializeComponent();
        }

        private void AddReturnSupplier_Load(object sender, EventArgs e)
        {
            labelPostingName.Text = NamePosting;
            labelSupplier.Text = NameSupplier;
            labelWarehouse.Text = NameWarehouse;

            dataGridViewReturn.Columns.Add("Номер", "Номер");
            dataGridViewReturn.Columns.Add("Наименование", "Наименование");
            dataGridViewReturn.Columns.Add("Кол-во", "Кол-во");
            dataGridViewReturn.Columns.Add("Цена", "Цена");
            dataGridViewReturn.Columns.Add("Сумма", "Сумма");

            var com = new MySqlCommand("SELECT * FROM tovpostingservice WHERE `Номер оприходования` = @Nomer");
            com.Parameters.AddWithValue("@Nomer", idPosting);
            dataGridViewTemp.DataSource = Program.Database.Query(com);

            foreach (DataGridViewRow row in dataGridViewTemp.Rows)
            {
                var number = row.Cells["Номер"].Value.ToString();
                var name = row.Cells["Наименование"].Value.ToString();
                var count = Int32.Parse(row.Cells["Кол-во"].Value.ToString());
                var price = row.Cells["Цена"].Value.ToString();
                dataGridViewReturn.Rows.Add(number, name, "0 / " + count, price, 0);
            }
        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            SelectCountTovar g = new SelectCountTovar();
            g.IdGoods = Int32.Parse(dataGridViewReturn.SelectedRows[0].Cells["Номер"].Value.ToString());
            g.NameTovar = dataGridViewReturn.SelectedRows[0].Cells["Наименование"].Value.ToString();
            g.IdPosting = idPosting;
            Price = Int32.Parse(dataGridViewReturn.SelectedRows[0].Cells["Цена"].Value.ToString());
            var s = dataGridViewReturn.SelectedRows[0].Cells["Кол-во"].Value.ToString();
            var found = s.IndexOf("/ ");
            Count = Int32.Parse(s.Substring(found  + 2));
            g.Count = Int32.Parse(s.Substring(found + 2));
            g.IsReturn = false;
            g.ShowDialog();

            if (g.IsSelected)
            {
                foreach (DataGridViewRow row in dataGridViewReturn.Rows)
                {
                    if (Int32.Parse(row.Cells["Номер"].Value.ToString()) == g.IdGoods)
                    {
                        row.Cells["Кол-во"].Value = g.Count + " / " + Count;
                        row.Cells["Сумма"].Value = g.Count * Price;
                        break;
                    }
                }
            }
        }

        public int CountData(DataGridViewRow row)
        {
            var s = row.Cells["Кол-во"].Value.ToString();
            var found = s.IndexOf(" ");
            return Int32.Parse(s.Substring(0, found));
        }

        private void buttonReturnSupplier_Click(object sender, EventArgs e)
        {
            var flag = false;
            foreach (DataGridViewRow row in dataGridViewReturn.Rows)
            {
                var count = CountData(row);
                if (count != 0)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Вы не возратили ни одного предмета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddReturnSupplierDB();
            foreach (DataGridViewRow row in dataGridViewReturn.Rows)
            {
                var count = CountData(row);
                if (count != 0)
                {
                    AddTovReturn(row);
                    EditGoodsInStockMinus(row);
                }
            }
            IsAdded = true;
            this.Close();
            MessageBox.Show("Возврат оформлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddTovReturn(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT idReturnSupplier FROM returnsupplier WHERE idReturnSupplier=(SELECT max(`idReturnSupplier`) FROM returnsupplier)");
            var data = Program.Database.Query(com);
            var lastId = Int32.Parse(data.Rows[0]["idReturnSupplier"].ToString());

            com = new MySqlCommand("CALL AddTovReturn(@ReturnSupplierId, @GoodsId, @Count, @Price, @PostingId)");
            com.Parameters.AddWithValue("@ReturnSupplierId", lastId);
            com.Parameters.AddWithValue("@GoodsId", Int32.Parse(row.Cells["Номер"].Value.ToString()));
            com.Parameters.AddWithValue("@Count", CountData(row));
            com.Parameters.AddWithValue("@Price", Int32.Parse(row.Cells["Цена"].Value.ToString()));
            com.Parameters.AddWithValue("@PostingId", idPosting);
            Program.Database.Query(com);
        }

        public void EditGoodsInStockMinus(DataGridViewRow row)
        {
            var com = new MySqlCommand("SELECT * FROM goodsinstock WHERE idGoodsinstock = @GoodsId");
            com.Parameters.AddWithValue("@GoodsId", Int32.Parse(row.Cells["Номер"].Value.ToString()));
            var data = Program.Database.Query(com);
            var idGoods = Int32.Parse(data.Rows[0]["idGoodsinstock"].ToString());

            com = new MySqlCommand("CALL EditGoodsInStockMinus(@Count, @GoodsInStockId)");
            com.Parameters.AddWithValue("@Count", CountData(row));
            com.Parameters.AddWithValue("@GoodsInStockId", idGoods);
            Program.Database.Query(com);
        }

        public int CalculateTotal()
        {
            var total = 0;
            var price = 0;
            var count = 0;
            foreach (DataGridViewRow row in dataGridViewReturn.Rows)
            {
                var count1 = CountData(row);
                if (row.Cells["Кол-во"].Value != null)
                    count = count1;
                if (row.Cells["Цена"].Value != null)
                    price = Int32.Parse(row.Cells["Цена"].Value.ToString());
                total += count * price;
            }
            return total;
        }

        public void AddReturnSupplierDB()
        {
            var com = new MySqlCommand("CALL AddReturnSupplier(@PostingId, @DateReturn, @Warehouse, @Supplier, @Employee, @Summa)");
            com.Parameters.AddWithValue("@PostingId", idPosting); 
            com.Parameters.AddWithValue("@DateReturn", DateTime.Now);
            com.Parameters.AddWithValue("@Warehouse", NameWarehouse);
            com.Parameters.AddWithValue("@Supplier", NameSupplier);
            com.Parameters.AddWithValue("@Employee", Program.User.NameUser);
            com.Parameters.AddWithValue("@Summa", CalculateTotal());
            Program.Database.Query(com);
        }
    }
}
