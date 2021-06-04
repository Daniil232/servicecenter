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
    public partial class AddOrder : Form
    {
        public bool IsAdded { get; set; } = false;
        private int idclient = -1;
        private int idproduct = -1;
        public AddOrder()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            comboBoxManager.DataSource = Program.Database.Query("Select * FROM manager");
            comboBoxManager.ValueMember = "idManager";
            comboBoxManager.DisplayMember = "Name";

            comboBoxExecutor.DataSource = Program.Database.Query("Select * FROM executor");
            comboBoxExecutor.ValueMember = "idExecutor";
            comboBoxExecutor.DisplayMember = "Name";

            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            SelectClient s = new SelectClient();
            s.ShowDialog();

            if (s.IsSelected)
            {
                idclient = s.ID;
                textBoxClient.Text = s.NameClient + " " + s.Telephone;
                buttonSelectClient.Text = "Изменить";
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (idproduct == -1 || idclient == -1)
            {
                MessageBox.Show("Вы не выбрали клиента или изделие!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var com = new MySqlCommand("CALL AddOrder(@ClientId, @Equipment, @Malfunction, @DateReadiness, @ManagerId, @ExecutorId, @ProductId, @DateAccepted)");
                com.Parameters.AddWithValue("@ClientId", idclient);
                com.Parameters.AddWithValue("@ProductId", idproduct);
                com.Parameters.AddWithValue("@Equipment", textBoxEquipment.Text);
                com.Parameters.AddWithValue("@Malfunction", textBoxMalfunction.Text);
                com.Parameters.AddWithValue("@DateAccepted", dateTimePicker1.Value);
                com.Parameters.AddWithValue("@DateReadiness", dateTimePicker1.Value.AddDays(3));
                com.Parameters.AddWithValue("@ManagerId", comboBoxManager.SelectedValue);
                com.Parameters.AddWithValue("@ExecutorId", comboBoxExecutor.SelectedValue);
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

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            if (textBoxClient.Text == "")
            {
                MessageBox.Show("Вы не выбрали клиента!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SelectProduct s = new SelectProduct();
                s.IdClient = idclient;
                s.NameClient = textBoxClient.Text;
                s.ShowDialog();

                if (s.IsSelected)
                {
                    idproduct = s.ID;
                    textBoxProduct.Text = s.NameProduct;
                    buttonSelectProduct.Text = "Изменить";
                }
            }
        }
    }
}
