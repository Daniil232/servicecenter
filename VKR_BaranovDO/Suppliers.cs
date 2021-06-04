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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            dataGridViewSupplier.DataSource = Program.Database.Query("SELECT * FROM supplierservice");
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddClient addSupplier = new AddClient();
            addSupplier.checkBoxSupplier.Checked = true;
            addSupplier.ShowDialog();
            if (addSupplier.IsAdded)
                Initialize();
        }
    }
}
