using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VKR_BaranovDO
{
    public partial class Orders : Form
    {
        public bool ContinueLogin { get; set; } = false;
        public Orders()
        {
            InitializeComponent();
            Initialize();
            
        }
        void Initialize()
        {
            dataGridViewOrders.DataSource = Program.Database.Query("SELECT * FROM orderservice");
            dataGridViewOrders.Columns["Номер статуса"].Visible = false;
            dataGridViewOrders.Columns["Номер товара"].Visible = false;

            ColorRow();
        }

        private void buttonAddOrders_Click(object sender, EventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.ShowDialog();

            if (addorder.IsAdded)
                Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.User.IsAdmin)
                this.Close();
            else
            {
                ContinueLogin = true;
                this.Close();
            }
        }

        public void DataGridColumnsVisibleFalse()
        {
            dataGridViewOrders.Columns["Номер статуса"].Visible = false;
            dataGridViewOrders.Columns["Номер товара"].Visible = false;
        }

        private void buttonAddCompletedWork_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var com = new MySqlCommand("SELECT * FROM servicecenter.order WHERE idOrder = @idOrder");
                com.Parameters.AddWithValue("@idOrder", (int)dataGridViewOrders.SelectedRows[0].Cells["Номер заказа"].Value);
                var table = Program.Database.Query(com);

                CompletedWork g = new CompletedWork();
                g.NameOrderProduct = dataGridViewOrders.SelectedRows[0].Cells["Наименование"].Value.ToString();
                g.IdOrder = (int)dataGridViewOrders.SelectedRows[0].Cells["Номер заказа"].Value;
                g.IdStatus = (int)dataGridViewOrders.SelectedRows[0].Cells["Номер статуса"].Value;
                g.IdExecutor = Int32.Parse(table.Rows[0]["ExecutorId"].ToString());
                g.NameClient = dataGridViewOrders.SelectedRows[0].Cells["Имя клиента"].Value.ToString();
                g.IdProduct = (int)dataGridViewOrders.SelectedRows[0].Cells["Номер товара"].Value;
                g.NameManager = dataGridViewOrders.SelectedRows[0].Cells["Создан"].Value.ToString();
                g.Initialize();
                g.ShowDialog();

                if (g.IsChanged)
                    Initialize();
            }
            else
            {
                MessageBox.Show("Вы не выбрали заказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ColorRow()
        {
            dataGridViewOrders.CurrentCell = null;
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                var status = row.Cells["Статус заказа"].Value.ToString();
                var deadline = (DateTime)row.Cells["Срок заказа"].Value;
                var date = DateTime.Now;
                switch (status)
                {
                    case "В работе":
                        if (date > deadline)
                            row.DefaultCellStyle.BackColor = Color.Red;
                        else
                            row.DefaultCellStyle.BackColor = Color.Linen;
                        break;
                    case "Готов":
                        row.DefaultCellStyle.BackColor = Color.Pink;
                        break;
                    case "Ждет запчасть":
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        break;
                    case "Закрыт":
                        row.DefaultCellStyle.BackColor = Color.Gray;
                        break;
                    case "Новый":
                        if (date > deadline)
                            row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            if (!Program.User.IsAdmin)
                buttonAddOrders.Visible = false;
            ColorRow();
        }
    }
}
