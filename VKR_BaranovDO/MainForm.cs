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
    public partial class MainForm : Form
    {
        public bool ContinueLogin { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
            this.Show();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warehouse warehouse = new Warehouse();
            warehouse.ShowDialog();
            this.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users g = new Users();
            g.ShowDialog();
            this.Show();
        }

        private void buttonExecutors_Click(object sender, EventArgs e)
        {
            this.Hide();
            Executors g = new Executors();
            g.ShowDialog();
            this.Show();
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managers g = new Managers();
            g.ShowDialog();
            this.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports g = new Reports();
            g.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            ContinueLogin = true;
            this.Close();
        }
    }
}
