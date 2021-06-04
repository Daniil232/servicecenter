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
    public partial class WaitingTovar : Form
    {
        private int idTovar = -1;
        public int idOrder { get; set; } = -1;
        private string NameTovar = "";
        public WaitingTovar()
        {
            InitializeComponent();
        }

        private void WaitingTovar_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        public void Initialize()
        {
            var com = new MySqlCommand("SELECT * FROM waitingservice WHERE `Номер заказа` = @Order");
            com.Parameters.AddWithValue("@Order", idOrder);
            dataGridViewWaiting.DataSource = Program.Database.Query(com);

            dataGridViewWaiting.Columns["id"].Visible = false;
            dataGridViewWaiting.Columns["Номер заказа"].Visible = false;
            dataGridViewWaiting.Columns["Номер товара"].Visible = false;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectTovar s = new SelectTovar();
            s.IsPosting = false;
            s.ShowDialog();

            if (s.IsSelected)
            {
                idTovar = s.IdTovar;
                NameTovar = s.NameTovar;
                textBoxTovar.Text = s.NameTovar;
            }
        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            if (textBoxTovar.Text != "")
            {
                var com = new MySqlCommand("CALL AddWaiting(@OrderId, @TovarId, @Count)");
                com.Parameters.AddWithValue("@OrderId", idOrder);
                com.Parameters.AddWithValue("@TovarId", idTovar);
                com.Parameters.AddWithValue("@Count", numericUpDown1.Value.ToString());
                Program.Database.Query(com);
                Initialize();
                textBoxTovar.Text = "";
                numericUpDown1.Value = 1;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaiting.Rows.Count == 0)
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.Close();
                MessageBox.Show("Запчасти заказаны!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaiting.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var com = new MySqlCommand("CALL DeleteWaiting(@WaitingId)");
                        com.Parameters.AddWithValue("@WaitingId", dataGridViewWaiting.SelectedRows[0].Cells["id"].Value);
                        Program.Database.Query(com);
                        Initialize();
                    }
                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
