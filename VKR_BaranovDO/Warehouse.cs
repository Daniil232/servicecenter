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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();

            var mounth = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var date = new DateTime(year, mounth, 1);

            InitializeDateTimePicker(dateTimePicker1, "dd/MM/yyyy", date);
            InitializeDateTimePicker(dateTimePicker3, "dd/MM/yyyy", date);
            InitializeDateTimePicker(dateTimePicker2, "dd/MM/yyyy", DateTime.Now);
            InitializeDateTimePicker(dateTimePicker4, "dd/MM/yyyy", DateTime.Now);
            InitializeDateTimePicker(dateTimePicker5, "dd/MM/yyyy", date);
            InitializeDateTimePicker(dateTimePicker6, "dd/MM/yyyy", DateTime.Now);
            InitializeDateTimePicker(dateTimePickerWriteoffgoods1, "dd/MM/yyyy", date);
            InitializeDateTimePicker(dateTimePickerWriteoffgoods2, "dd/MM/yyyy", DateTime.Now);

            Initialize();
        }
        void Initialize()
        {
            dataGridViewGoods.DataSource = Program.Database.Query("SELECT * FROM goodsinstockservice");

            var com = new MySqlCommand("SELECT * FROM postingservice WHERE `Дата и время` BETWEEN @Date1 AND @Date2");
            com.Parameters.AddWithValue("@Date1", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@Date2", dateTimePicker2.Value.AddHours(1));
            dataGridViewPosting.DataSource = Program.Database.Query(com);

            com = new MySqlCommand("SELECT * FROM movingservice WHERE `Дата и время` BETWEEN @Date1 AND @Date2");
            com.Parameters.AddWithValue("@Date1", dateTimePicker3.Value);
            com.Parameters.AddWithValue("@Date2", dateTimePicker4.Value.AddHours(1));
            dataGridViewMoving.DataSource = Program.Database.Query(com);

            dataGridViewMoving.Columns["Склад1"].Visible = false;
            dataGridViewMoving.Columns["Склад2"].Visible = false;
            dataGridViewMoving.Columns["idWarehouse"].Visible = false;

            dataGridViewGoods.Columns["Номер записи"].Visible = false;
            dataGridViewGoods.Columns["Номер товара"].Visible = false;
            dataGridViewGoods.Columns["Номер склада"].Visible = false;

            com = new MySqlCommand("SELECT * FROM writeoffgoodsservice WHERE `Дата и время` BETWEEN @Date1 AND @Date2");
            com.Parameters.AddWithValue("@Date1", dateTimePickerWriteoffgoods1.Value);
            com.Parameters.AddWithValue("@Date2", dateTimePickerWriteoffgoods2.Value.AddHours(1));
            dataGridViewWriteoffgoods.DataSource = Program.Database.Query(com);

            com = new MySqlCommand("SELECT * FROM returnsupplierservice WHERE `Дата и время` BETWEEN @Date1 AND @Date2");
            com.Parameters.AddWithValue("@Date1", dateTimePicker5.Value);
            com.Parameters.AddWithValue("@Date2", dateTimePicker6.Value.AddHours(1));
            dataGridViewReturnSupplier.DataSource = Program.Database.Query(com);
        }

        public void InitializeDateTimePicker(DateTimePicker name, string customformat, DateTime value)
        {
            name.Format = DateTimePickerFormat.Custom;
            name.CustomFormat = customformat;
            name.Value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddPosting_Click(object sender, EventArgs e)
        {
            AddPosting addposting = new AddPosting();
            addposting.ShowDialog();

            if (addposting.IsAdded)
                Initialize();
        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            if (dataGridViewPosting.SelectedRows.Count != 0)
            {
                LookPosting p = new LookPosting();
                p.idPosting = (int)dataGridViewPosting.SelectedRows[0].Cells["Номер оприходования"].Value;
                p.DatePosting = dataGridViewPosting.SelectedRows[0].Cells["Дата и время"].Value.ToString();
                p.NamePosting = dataGridViewPosting.SelectedRows[0].Cells["Накладная №"].Value.ToString();
                p.NameSupplier = dataGridViewPosting.SelectedRows[0].Cells["Поставщик"].Value.ToString();
                p.NameWarehouse = dataGridViewPosting.SelectedRows[0].Cells["Склад"].Value.ToString();
                p.EmployeeName = dataGridViewPosting.SelectedRows[0].Cells["Сотрудник"].Value.ToString();
                p.ShowDialog();
                if (p.IsAdded)
                    Initialize();
            } 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMoving g = new AddMoving();
            g.ShowDialog();
            if (g.IsAdded)
                Initialize();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewMoving.SelectedRows.Count != 0)
            {
                LookMoving p = new LookMoving();
                p.IdMoving = (int)dataGridViewMoving.SelectedRows[0].Cells["Номер перемещения"].Value;
                p.DateMoving = dataGridViewMoving.SelectedRows[0].Cells["Дата и время"].Value.ToString();
                p.NameMoving = dataGridViewMoving.SelectedRows[0].Cells["Номер перемещения"].Value.ToString();
                p.NameWarehouse1 = dataGridViewMoving.SelectedRows[0].Cells["Со склада"].Value.ToString();
                p.NameWarehouse2 = dataGridViewMoving.SelectedRows[0].Cells["На склад"].Value.ToString();
                p.EmployeeName = dataGridViewMoving.SelectedRows[0].Cells["Сотрудник"].Value.ToString();
                p.ShowDialog();
            }
        }

        private void buttonAddWriteoffgoods_Click(object sender, EventArgs e)
        {
            AddWriteoffgoods g = new AddWriteoffgoods();
            g.ShowDialog();
            if (g.IsAdded)
                Initialize();
        }

        private void buttonLookWriteoffgoods_Click(object sender, EventArgs e)
        {
            if (dataGridViewWriteoffgoods.SelectedRows.Count != 0)
            {
                LookWriteoffgoods p = new LookWriteoffgoods();
                p.idWriting = (int)dataGridViewWriteoffgoods.SelectedRows[0].Cells["Списание №"].Value;
                p.DateWriting = dataGridViewWriteoffgoods.SelectedRows[0].Cells["Дата и время"].Value.ToString();
                p.NameWriting = dataGridViewWriteoffgoods.SelectedRows[0].Cells["Списание №"].Value.ToString();
                p.NameWarehouse = dataGridViewWriteoffgoods.SelectedRows[0].Cells["Склад"].Value.ToString();
                p.EmployeeName = dataGridViewWriteoffgoods.SelectedRows[0].Cells["Сотрудник"].Value.ToString();
                p.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturnSupplier.SelectedRows.Count != 0)
            {
                var p = new LookReturnSupplier();
                p.idReturn = (int)dataGridViewReturnSupplier.SelectedRows[0].Cells["Номер возврата"].Value;
                p.NameReturn = dataGridViewReturnSupplier.SelectedRows[0].Cells["Номер возврата"].Value.ToString();
                p.DateReturn = dataGridViewReturnSupplier.SelectedRows[0].Cells["Дата и время"].Value.ToString();
                p.NameWarehouse = dataGridViewReturnSupplier.SelectedRows[0].Cells["Склад"].Value.ToString();
                p.NameSupplier = dataGridViewReturnSupplier.SelectedRows[0].Cells["Поставщик"].Value.ToString();
                p.EmployeeName = dataGridViewReturnSupplier.SelectedRows[0].Cells["Сотрудник"].Value.ToString();
                p.ShowDialog();
            }
        }
    }
}
