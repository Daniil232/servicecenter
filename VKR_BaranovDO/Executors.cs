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
    public partial class Executors : Form
    {
        public Executors()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxExecutor.Text == "")
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL AddExecutor(@Name)");
                com.Parameters.AddWithValue("@Name", textBoxExecutor.Text);
                Program.Database.Query(com);
                MessageBox.Show("Успешное добавление!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Executors_Load(sender, e);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var com = new MySqlCommand("CALL DeleteExecutor(@ExecutorId)");
                        com.Parameters.AddWithValue("@ExecutorId", dataGridView.SelectedRows[0].Cells["idExecutor"].Value);
                        Program.Database.Query(com);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Executors_Load(sender, e);
                    }

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Executors_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Program.Database.Query("SELECT * FROM Executor");
        }
    }
}
