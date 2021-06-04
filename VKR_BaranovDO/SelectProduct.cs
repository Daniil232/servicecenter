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
    public partial class SelectProduct : Form
    {
        public int ID { get; set; } = -1;
        public int IdClient { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameProduct { get; set; } = "";
        public string NameClient { get; set; } = "";
        public SelectProduct()
        {
            InitializeComponent();
        }
        public void Initialize()
        {
            var com = new MySqlCommand("SELECT * FROM productsservice WHERE `Номер клиента` = @ClientId");
            com.Parameters.AddWithValue("@ClientId", IdClient);
            dataGridViewProduct.DataSource = Program.Database.Query(com);
            dataGridViewProduct.Columns["Номер клиента"].Visible = false;
            if (dataGridViewProduct.Rows.Count == 0)
            {
                AddProduct g = new AddProduct();
                g.IdClient = IdClient;
                g.NameClient = NameClient;
                g.ShowDialog();

                if (g.IsAdded)
                {
                    dataGridViewProduct.DataSource = Program.Database.Query("SELECT * FROM productsservice WHERE `Номер изделия`=(SELECT max(`Номер изделия`) FROM productsservice)");
                    ID = Convert.ToInt32(dataGridViewProduct.SelectedRows[0].Cells["Номер изделия"].Value);
                    NameProduct = Convert.ToString(dataGridViewProduct.SelectedRows[0].Cells["Наименование"].Value);
                    IsSelected = true;
                    this.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridViewProduct.SelectedRows[0].Cells["Номер изделия"].Value);
                NameProduct = Convert.ToString(dataGridViewProduct.SelectedRows[0].Cells["Наименование"].Value);

                IsSelected = true;
                this.Close();
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddProduct g = new AddProduct();
            g.IdClient = IdClient;
            g.NameClient = NameClient;
            g.ShowDialog();

            if (g.IsAdded)
            {
                Initialize();
            }    
                
        }

        private void dataGridViewProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount + e.RowIndex == dataGridViewProduct.Rows.Count && ID != -1)
                foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                {
                    if ((int)row.Cells["Номер изделия"].Value == ID)
                    {
                        row.Selected = true;
                    }
                }
        }

        private void dataGridViewProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
