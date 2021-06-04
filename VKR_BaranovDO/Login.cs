using DatabaseProvider;
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
    public partial class Login : Form
    {
        private uint Attempts { get; set; } = 0;

        public Login()
        {
            InitializeComponent();
        }

        //private void buttonSave_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var connection = new MySqlConnection(string.Format("Server={0};Database={1};port={2};User Id={3};password={4}", textBoxServer.Text, textBoxDatabase.Text, Int32.Parse(textBoxPort.Text), textBoxUsername.Text, textBoxPassword.Text)); ;
        //        connection.Open();
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            Program.Database.SqlConnection = connection;
        //            MessageBox.Show("Подключение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            tabControl1.SelectTab(tabPage1);
        //        }
        //        connection.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Login_Load(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT * FROM manager UNION ALL SELECT * FROM executor");
            comboBox1.DataSource = Program.Database.Query(com);
            comboBox1.DisplayMember = "Name";
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (PasswordField.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.Database.ExistsUser(comboBox1.Text, PasswordField.Text))
            {
                this.Hide();

                if (Program.Database.UserIsAdmin(comboBox1.Text, PasswordField.Text))
                    Program.User.IsAdmin = true;

                Program.User.NameUser = comboBox1.Text;
                if (!Program.User.IsAdmin)
                {
                    Orders orders = new Orders();
                    orders.ShowDialog();
                    if (orders.ContinueLogin)
                    {
                        Attempts = 0;
                        PasswordField.Text = "";
                        Program.User.IsAdmin = false;
                        this.Show();
                    }
                    else
                        this.Close();
                }
                else
                {
                    var mainForm = new MainForm();
                    mainForm.ShowDialog();

                    if (mainForm.ContinueLogin)
                    {
                        Attempts = 0;
                        PasswordField.Text = "";
                        Program.User.IsAdmin = false;
                        this.Show();
                    }
                    else
                        this.Close();
                }
            }
            else
            {

                MessageBox.Show("Неверное имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordField.Text = "";

                Attempts++;

                if (Attempts == 3)
                    this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PasswordField.Text = "";
        }
    }
}
