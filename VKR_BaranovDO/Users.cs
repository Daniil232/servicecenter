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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Program.Database.Query("SELECT * FROM user");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var com = new MySqlCommand("CALL DeleteUser(@UserId)");
                        com.Parameters.AddWithValue("@UserId", dataGridView.SelectedRows[0].Cells["idUser"].Value);
                        Program.Database.Query(com);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Users_Load(sender, e);
                    }

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
            Users_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                        var com = new MySqlCommand("CALL DoAdmin(@UserId)");
                        com.Parameters.AddWithValue("@UserId", dataGridView.SelectedRows[0].Cells["idUser"].Value);
                        Program.Database.Query(com);
                        MessageBox.Show("Админ добавлен", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Users_Load(sender, e);
                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var g = new ChangePassword();
            g.NameUser = dataGridView.SelectedRows[0].Cells["login"].Value.ToString();
            g.IdUser  = (int)dataGridView.SelectedRows[0].Cells["idUser"].Value;
            g.ShowDialog();
        }
    }
}
