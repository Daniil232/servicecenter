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
    public partial class ChangePassword : Form
    {
        public string NameUser { get; set; } = "";
        public int IdUser { get; set; } = -1;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private bool ValidatePassword(string password)
        {
            var input = password;
            var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                labelError.Text = "Пароль должен содержать букву нижнего регистра";
                return false;
            }
            //else if (!hasUpperChar.IsMatch(input))
            //{
            //    labelError.Text = "Пароль должен содержать букву вверхнего регистра";
            //    return false;
            //}
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                labelError.Text = "Пароль должен содержать больше 8 букв";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                labelError.Text = "Пароль должен содержать цифру";
                return false;
            }
            else
            {
                labelError.Text = "";
                return true;
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            labelNameUser.Text = NameUser;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxChange1.Text != textBoxChange2.Text)
                    return;

                if (!ValidatePassword(textBoxChange1.Text))
                {
                    return;
                }
                else
                {
                    var com = new MySqlCommand("SELECT * FROM `user` WHERE login = @Nameuser");
                    com.Parameters.AddWithValue("@Nameuser", NameUser);
                    var table = Program.Database.Query(com);

                    com = new MySqlCommand("UPDATE user SET user.hashCode = @hash WHERE idUser = @User");
                    com.Parameters.AddWithValue("@hash", Program.Database.GetHash(NameUser, textBoxChange1.Text));
                    com.Parameters.AddWithValue("@User", IdUser);
                    Program.Database.Query(com);
                    MessageBox.Show("Пароль успешно поменялся!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxChange1_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword(textBoxChange1.Text);
        }

        private void textBoxChange2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxChange1.Text != textBoxChange2.Text)
                labelError.Text = "Повторный пароль неверный";
            else
                labelError.Text = "";
        }
    }
}
