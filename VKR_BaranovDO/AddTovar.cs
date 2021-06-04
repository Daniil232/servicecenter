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
    public partial class AddTovar : Form
    {
        public bool IsAdded { get; set; } = false;
        public bool IsEdit { get; set; } = false;
        public string NameTovar { get; set; } = "";
        public string Description { get; set; } = "";
        public string Articyle { get; set; } = "";
        public int PriceRepair { get; set; } = -1;
        public int PriceRetail { get; set; } = -1;
        public int idTovar { get; set; } = -1;

        public AddTovar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                    var com = new MySqlCommand("CALL AddTovar(@Name, @Description, @Vendor, @PriceRepair, @PriceRetail)");
                    com.Parameters.AddWithValue("@Name", textBoxName.Text);
                    com.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                    com.Parameters.AddWithValue("@Vendor", textBoxVendor.Text);
                    com.Parameters.AddWithValue("@PriceRepair", numericUpDown1.Value);
                    com.Parameters.AddWithValue("@PriceRetail", numericUpDown2.Value);
                    
                    Program.Database.Query(com);
                    IsAdded = true;
                    this.Close();

                    MessageBox.Show("Товар успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTovar_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                buttonSave.Visible = false;
                textBoxDescription.Text = Description;
                textBoxName.Text = NameTovar;
                textBoxVendor.Text = Articyle;
                numericUpDown1.Value = PriceRepair;
                numericUpDown2.Value = PriceRetail;
            }
                
            else buttonEdit.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL EditTovar(@TovarId, @Name, @Description, @Vendor, @PriceRepair, @PriceRetail)");
                com.Parameters.AddWithValue("@TovarId", idTovar);
                com.Parameters.AddWithValue("@Name", textBoxName.Text);
                com.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                com.Parameters.AddWithValue("@Vendor", textBoxVendor.Text);
                com.Parameters.AddWithValue("@PriceRepair", numericUpDown1.Value);
                com.Parameters.AddWithValue("@PriceRetail", numericUpDown2.Value);

                Program.Database.Query(com);
                IsAdded = true;
                this.Close();

                MessageBox.Show("Товар успешно изменен!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
