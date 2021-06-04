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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            dataGridViewClients.DataSource = Program.Database.Query("SELECT * FROM clientsservice");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить Клиента? При удалении клиента, все заказы, с которомы он был связан будут удалены!", "Удаление клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        var com = new MySqlCommand("CALL DeleteClient(@idClient)");
                        com.Parameters.AddWithValue("@idClient", dataGridViewClients.SelectedRows[0].Cells["Номер клиента"].Value);
                        Program.Database.Query(com);

                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Initialize();
                    }

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();

            if (addClient.IsAdded)
                Initialize();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var g = new AddClient();
                g.IsEdit = true;
                g.IdClient = Int32.Parse(dataGridViewClients.SelectedRows[0].Cells["Номер клиента"].Value.ToString());
                g.NameClient = dataGridViewClients.SelectedRows[0].Cells["Имя"].Value.ToString();
                g.Telephone = dataGridViewClients.SelectedRows[0].Cells["Телефон"].Value.ToString();
                g.Address = dataGridViewClients.SelectedRows[0].Cells["Адрес"].Value.ToString();
                g.Email = dataGridViewClients.SelectedRows[0].Cells["Email"].Value.ToString();
                g.ShowDialog();
                if (g.IsAdded)
                    Initialize();
            }
        }
    }
}
