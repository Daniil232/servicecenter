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
    public partial class AddBrand : Form
    {
        public int IdGroup { get; set; } = -1;
        public bool IsAdded { get; set; } = false;
        public AddBrand()
        {
            InitializeComponent();
        }

        private void AddBrand_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = Program.Database.Query("SELECT * FROM servicecenter.group;");
            comboBoxGroup.ValueMember = "idGroup";
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.SelectedValue = IdGroup;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.Text == "" || IdGroup == -1)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL AddBrand(@GroupId, @Name)");
                com.Parameters.AddWithValue("@GroupId", comboBoxGroup.SelectedValue);
                com.Parameters.AddWithValue("@Name", textBoxBrand.Text);
                Program.Database.Query(com);


                IsAdded = true;
                this.Close();

                MessageBox.Show("Бренд успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
