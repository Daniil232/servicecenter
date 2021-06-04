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
    public partial class AddGroup : Form
    {
        public bool IsAdded { get; set; } = false;
        public AddGroup()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxGroup.Text == "")
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL AddGroup(@Name)");
                com.Parameters.AddWithValue("@Name", textBoxGroup.Text);
                Program.Database.Query(com);

                IsAdded = true;
                this.Close();

                MessageBox.Show("Группа успешна добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
