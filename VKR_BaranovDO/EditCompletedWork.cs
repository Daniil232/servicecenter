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
    public partial class EditCompletedWork : Form
    {
        public bool IsChanged { get; set; } = false;
        public int IdCompletedWork { get; set; } = -1;
        public int Count { get; set; } = -1;
        public int Price { get; set; } = -1;
        public EditCompletedWork()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            numericUpDownCount.Value = Count;
            numericUpDownPrice.Value = Price;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var com = new MySqlCommand("CALL EditCompletedWork(@Count, @Price, @CompletedId)");
                com.Parameters.AddWithValue("@CompletedId", IdCompletedWork);
                com.Parameters.AddWithValue("@Count", numericUpDownCount.Value);
                com.Parameters.AddWithValue("@Price", numericUpDownPrice.Value);
                Program.Database.Query(com);

                IsChanged = true;

                MessageBox.Show("Информация о работе успешно изменена!", "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
