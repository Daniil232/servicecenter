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
    public partial class SelectCountAndPrice : Form
    {
        public int Count { get; set; } = -1;
        public int IdTovar { get; set; } = -1;
        public int Price { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameTovar { get; set; } = "";
        public double Repair { get; set; } = 0;
        public double Retail { get; set; } = 0;
        public SelectCountAndPrice()
        {
            InitializeComponent();
            
        }

        private bool IsNumber(string str)
        {
            int Num;
            return int.TryParse(str, out Num);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsNumber(textBox1.Text))
            {
                if (buttonShowPrice.Text == "Скрыть розничные цены")
                {
                    var com = new MySqlCommand("CALL EditTovarPrice(@TovarId, @PriceRepair, @PriceRetail)");
                    com.Parameters.AddWithValue("@TovarId", IdTovar);
                    com.Parameters.AddWithValue("@PriceRepair", numericUpDownRepair.Value);
                    com.Parameters.AddWithValue("@PriceRetail", numericUpDownRetail.Value);
                    Program.Database.Query(com);
                }
                Count = Convert.ToInt32(numericUpDown1.Value);
                Price = Convert.ToInt32(Int32.Parse(textBox1.Text));
                Repair = (double)numericUpDownRepair.Value;
                Retail = (double)numericUpDownRetail.Value;

                IsSelected = true;
                this.Close();
            }
        }

        private void SelectCount_Load(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT PriceRepair, PriceRetail FROM tovar WHERE `idTovar` = @TovarId");
            com.Parameters.AddWithValue("@TovarId", IdTovar);
            var data = Program.Database.Query(com);

            numericUpDownRepair.Value = Int32.Parse(data.Rows[0]["PriceRepair"].ToString());
            numericUpDownRetail.Value = Int32.Parse(data.Rows[0]["PriceRetail"].ToString());

            groupBox1.Visible = false;
            label1.Text = NameTovar;

            com = new MySqlCommand("SELECT TovarId, Sum(Count) AS `NeedCount` FROM `waitingtovar` WHERE TovarId = @TovarId group BY TovarId");
            com.Parameters.AddWithValue("@TovarId", IdTovar);
            data = Program.Database.Query(com);
            if (data.Rows.Count != 0)
            {
                if (data.Rows[0]["NeedCount"].ToString() != "0")
                    labelNeed.Text = "Необходимо: " + data.Rows[0]["NeedCount"].ToString();
            }
            else
                labelNeed.Text = "";
        }

        private void buttonShowPrice_Click(object sender, EventArgs e)
        {
            if (buttonShowPrice.Text == "Показать розничные цены")
            {
                buttonShowPrice.Text = "Скрыть розничные цены";
                groupBox1.Visible = true;
            }
            else
            {
                buttonShowPrice.Text = "Показать розничные цены";
                groupBox1.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDownRepair.Value = System.Math.Truncate((decimal)Repair);
            numericUpDownRetail.Value = System.Math.Truncate((decimal)Retail);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Repair = Int32.Parse(textBox1.Text);
                Repair = Repair * 1.5;
                Retail = Int32.Parse(textBox1.Text);
                Retail = Retail * 2;

                labelRepair.Text = Repair.ToString();
                labelRetail.Text = Retail.ToString();

                labelError.Text = "";
            }
            catch
            {
                labelError.Text = "Вы ввели не число";
            }
           
        }
    }
}
