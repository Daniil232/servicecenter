using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR_BaranovDO
{
    public partial class AddClient : Form
    {
        public bool IsAdded { get; set; } = false;
        public bool IsEdit { get; set; } = false;
        public int IdClient { get; set; } = -1;
        public string NameClient { get; set; } = "";
        public string Telephone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public AddClient()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (regex.IsMatch(email))
                labelError.Text = "";
            else
                labelError.Text = "Формат (qwerty@mail.ru)";
            return regex.IsMatch(email);
        }



        private void btnSaveAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || maskedTextBoxTelephone.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные или форма адреса не соотвествует стандарту!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (IsValidEmail(textBoxEmail.Text) || textBoxAddress.Text == "")
                {
                    labelError.Text = "";
                   if (checkBoxSupplier.Checked)
                    {
                        var com = new MySqlCommand("CALL AddSupplier(@Name, @Telephone , @Email, @Address)");
                        com.Parameters.AddWithValue("@Name", textBoxName.Text);
                        com.Parameters.AddWithValue("@Telephone", maskedTextBoxTelephone.Text);
                        com.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        com.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                        Program.Database.Query(com);
                        IsAdded = true;
                        this.Close();

                        MessageBox.Show("Поставщик успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var com = new MySqlCommand("CALL AddClient(@Name, @Telephone , @Email, @Address)");
                        com.Parameters.AddWithValue("@Name", textBoxName.Text);
                        com.Parameters.AddWithValue("@Telephone", maskedTextBoxTelephone.Text);
                        com.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        com.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                        Program.Database.Query(com);
                        IsAdded = true;
                        this.Close();

                        MessageBox.Show("Клиент успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else
                {
                    MessageBox.Show("Формат адреса не верно введен!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            IsValidEmail(textBoxEmail.Text);
        }

        private void checkBoxSupplier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                checkBoxSupplier.Visible = false;
                btnSaveAddClient.Visible = false;
                textBoxName.Text = NameClient;
                textBoxAddress.Text = Address;
                textBoxEmail.Text = Email;
                maskedTextBoxTelephone.Text = Telephone;
            }
            else
            {
                buttonEdit.Visible = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var com = new MySqlCommand("CALL EditClient(@Name, @Telephone , @Email, @Address, @ClientId)");
            com.Parameters.AddWithValue("@Name", textBoxName.Text);
            com.Parameters.AddWithValue("@Telephone", maskedTextBoxTelephone.Text);
            com.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            com.Parameters.AddWithValue("@Address", textBoxAddress.Text);
            com.Parameters.AddWithValue("@ClientId", IdClient);
            Program.Database.Query(com);
            IsAdded = true;
            this.Close();

            MessageBox.Show("Данные о клиенте изменены!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
