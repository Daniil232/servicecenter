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
    public partial class AddCompeletedWork : Form
    {
        public bool IsAdded { get; set; } = false;
        public int IdOrder { get; set; } = -1;
        public AddCompeletedWork()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не вписали название изделия", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (checkBox1.Checked)
                {
                    var com1 = new MySqlCommand("CALL AddService(@Name, @Price)");
                    com1.Parameters.AddWithValue("@Name", textBoxName.Text);
                    com1.Parameters.AddWithValue("@Price", numericUpDownPrice.Value);
                    Program.Database.Query(com1);
                }

                var com = new MySqlCommand("CALL AddCompletedWork(@OrderId, @Name, @Price, @Count, @GoodsId)");
                com.Parameters.AddWithValue("@OrderId", IdOrder);
                com.Parameters.AddWithValue("@Name", textBoxName.Text);
                com.Parameters.AddWithValue("@Price", numericUpDownPrice.Value);
                com.Parameters.AddWithValue("@Count", numericUpDownCount.Value);
                com.Parameters.AddWithValue("@GoodsId", null);
                Program.Database.Query(com);

                com = new MySqlCommand("CALL EditStatus(@OrderId, @StatusId)");
                com.Parameters.AddWithValue("@OrderId", IdOrder);
                com.Parameters.AddWithValue("@StatusId", 2);
                Program.Database.Query(com);

                IsAdded = true;

                this.Close();
                MessageBox.Show("Запись успешно добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCompeletedWork_Load(object sender, EventArgs e)
        {

        }
    }
}
