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
    public partial class AddModel : Form
    {
        public int IdGroup { get; set; } = -1;
        public int IdBrand { get; set; } = -1;
        public bool IsAdded { get; set; } = false;
        public AddModel()
        {
            InitializeComponent();
        }

        private void AddModel_Load(object sender, EventArgs e)
        {
                var com = new MySqlCommand("SELECT * FROM servicecenter.brand WHERE GroupId = @GroupId");
                com.Parameters.AddWithValue("@GroupId", IdGroup);
                comboBoxBrand.DataSource = Program.Database.Query(com);
                comboBoxBrand.ValueMember = "idBrand";
                comboBoxBrand.DisplayMember = "Name";
                comboBoxBrand.SelectedValue = IdBrand;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxModel.Text == "" || IdBrand == -1)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL AddModel(@BrandId, @Name)");
                com.Parameters.AddWithValue("@BrandId", comboBoxBrand.SelectedValue);
                com.Parameters.AddWithValue("@Name", textBoxModel.Text);
                Program.Database.Query(com);

                IsAdded = true;
                this.Close();

                MessageBox.Show("Модель успешна добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
