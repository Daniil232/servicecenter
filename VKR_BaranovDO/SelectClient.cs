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
    public partial class SelectClient : Form
    {
        public int ID { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameClient { get; set; } = "";
        public string Telephone { get; set; } = "";
        public SelectClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["Номер клиента"].Value);
                NameClient = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells["Имя"].Value);
                Telephone = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells["Телефон"].Value);

                IsSelected = true;
                this.Close();
            }
        }

        private void dataGridViewClients_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount + e.RowIndex == dataGridViewClients.Rows.Count && ID != -1)
                foreach (DataGridViewRow row in dataGridViewClients.Rows)
                {
                    if ((int)row.Cells["Номер клиента"].Value == ID)
                    {
                        row.Selected = true;
                    }
                }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();

            if (addClient.IsAdded)
            {
                dataGridViewClients.DataSource = Program.Database.Query("SELECT * FROM clientsservice WHERE `Номер клиента`=(SELECT max(`Номер клиента`) FROM clientsservice)");
                button1_Click(sender, e);
            }        
        }

        private void dataGridViewClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT * FROM `clientsservice` WHERE `Телефон` LIKE @Telephone");
            com.Parameters.AddWithValue("@Telephone", "%" + textBoxTelephone.Text + "%");
            dataGridViewClients.DataSource = Program.Database.Query(com);
        }

        private void SelectClient_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = Program.Database.Query("SELECT * FROM clientsservice order by `Номер клиента` DESC");
        }
    }
}
