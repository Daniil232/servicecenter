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
using System.Windows.Forms.VisualStyles;

namespace VKR_BaranovDO
{
    public partial class AddProduct : Form
    {
        public bool IsAdded = false;
        private int IdGroup { get; set; } = -1;
        private int IdBrand { get; set; } = -1;
        private int IdModel { get; set; } = -1;
        public int IdClient { get; set; } = -1;
        private string OwnerProduct { get; set; } = "";
        public string NameClient { get; set; } = "";

        public AddProduct()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxIMEI.Text == "" || textBoxClient.Text == "" || comboBoxBrand.Text == "" || comboBoxBrand.Text == "" || comboBoxGroup.Text == "")
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                OwnerProduct = textBoxClient.Text;
                var com = new MySqlCommand("CALL AddProduct(@IMEI, @Color, @State, @GroupId, @BrandId, @ModelId, @ClientId)");
                com.Parameters.AddWithValue("@IMEI", textBoxIMEI.Text);
                com.Parameters.AddWithValue("@Color", textBoxColor.Text);
                com.Parameters.AddWithValue("@State", textBoxState.Text);
                com.Parameters.AddWithValue("@GroupId", comboBoxGroup.SelectedValue);
                com.Parameters.AddWithValue("@BrandId", comboBoxBrand.SelectedValue);
                com.Parameters.AddWithValue("@ModelId", comboBoxModel.SelectedValue);
                com.Parameters.AddWithValue("@ClientId", IdClient);
                Program.Database.Query(com);

                IsAdded = true;
                MessageBox.Show("Товар успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            if (IdClient != -1)
            {
                textBoxClient.Text = NameClient;
            }
            comboBoxGroup.DataSource = Program.Database.Query("SELECT * FROM servicecenter.group;");
            comboBoxGroup.ValueMember = "idGroup";
            comboBoxGroup.DisplayMember = "Name";

            textBoxClient.Text = NameClient;

            //comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;

            //comboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBoxGroup.AutoCompleteSource = AutoCompleteSource.ListItems;

            //comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            AddGroup g = new AddGroup();
            g.ShowDialog();

            if (g.IsAdded)
                AddProduct_Load(sender, e);
        }

        private void buttonBrand_Click(object sender, EventArgs e)
        {
            AddBrand g = new AddBrand();
            g.IdGroup = (int)comboBoxGroup.SelectedValue;
            g.ShowDialog();

            if (g.IsAdded)
                comboBoxGroup_SelectedIndexChanged(sender, e);
        }

        private void buttonModel_Click(object sender, EventArgs e)
        {
            if (comboBoxBrand.Text != "")
            {
                AddModel g = new AddModel();
                g.IdBrand = (int)comboBoxBrand.SelectedValue;
                g.IdGroup = (int)comboBoxGroup.SelectedValue;
                g.ShowDialog();

                if (g.IsAdded)
                    comboBoxBrand_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Вы не выбрали бренд", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxModel.SelectedIndex = -1;
                comboBoxBrand.SelectedIndex = -1;

                var com = new MySqlCommand("CALL FindBrand(@NGroup)");
                com.Parameters.AddWithValue("@NGroup", comboBoxGroup.SelectedValue);
                comboBoxBrand.DataSource = Program.Database.Query(com);
                comboBoxBrand.ValueMember = "idBrand";
                comboBoxBrand.DisplayMember = "Name";
            }
            catch { }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxModel.SelectedIndex = -1;
                var com = new MySqlCommand("CALL FindModel(@BrandId)");
                com.Parameters.AddWithValue("@BrandId", comboBoxBrand.SelectedValue);
                comboBoxModel.DataSource = Program.Database.Query(com);
                comboBoxModel.ValueMember = "idModel";
                comboBoxModel.DisplayMember = "Name";
            }
            catch { }
        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            SelectClient s = new SelectClient();
            s.ShowDialog();

            if (s.IsSelected)
            {
                IdClient = s.ID;
                textBoxClient.Text = s.NameClient + " " + s.Telephone;
                buttonSelectClient.Text = "Изменить";
            }
        }
    }
}
