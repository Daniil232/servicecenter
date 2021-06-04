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
using MySql.Data.MySqlClient;

namespace VKR_BaranovDO
{
    public partial class Registration : Form
    {
        public bool ContinueLogin { get; set; } = false;
        public Registration()
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
             try
            {
                if (comboBoxUser.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidatePassword(textBoxPassword.Text))
                {
                    return;
                }
                else
                {
                    var com = new MySqlCommand("SELECT * FROM `user` WHERE login = @Nameuser");
                    com.Parameters.AddWithValue("@Nameuser", comboBoxUser.Text);
                    var table = Program.Database.Query(com);

                    if (table.Rows.Count == 0)
                    {
                        if (comboBoxSelect.SelectedIndex == 0)
                            Program.Database.Register(comboBoxUser.Text, textBoxPassword.Text, 1);
                        else
                            Program.Database.Register(comboBoxUser.Text, textBoxPassword.Text, 0);
                        Program.User.SetHashKey(comboBoxUser.Text, textBoxPassword.Text);
                        MessageBox.Show("Пользователь успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        textBoxPassword.Text = "";
                        MessageBox.Show("Пользователь с данным логином уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void Registration_Load(object sender, EventArgs e)
        {
            comboBoxSelect.SelectedIndex = 0;
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelect.SelectedIndex == 0)
            {
                comboBoxUser.DataSource = Program.Database.Query("Select * FROM manager");
                comboBoxUser.ValueMember = "idManager";
                comboBoxUser.DisplayMember = "Name";
            }
            else
            {
                comboBoxUser.DataSource = Program.Database.Query("Select * FROM executor");
                comboBoxUser.ValueMember = "idExecutor";
                comboBoxUser.DisplayMember = "Name";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword(textBoxPassword.Text);
        }
    }
}
