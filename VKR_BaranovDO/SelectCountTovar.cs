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
    public partial class SelectCountTovar : Form
    {
        public bool IsSelected { get; set; } = false;
        public bool IsReturn { get; set; } = true;
        public int IdGoods { get; set; } = -1;
        public int IdPosting { get; set; } = -1;
        public int Count { get; set; } = -1;
        public string NameTovar { get; set; } = "";
        public SelectCountTovar()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown1.Value <= Int32.Parse(labelMaxCount.Text))
            {
                Count = (int)numericUpDown1.Value;
                IsSelected = true;
            }
            else
            {
                MessageBox.Show("Данного товара нет в наличии!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void SelectCountTovar_Load(object sender, EventArgs e)
        {
            labelNameTovar.Text = NameTovar;
            var com = new MySqlCommand("SELECT * FROM goodsinstock WHERE idGoodsinstock = @IdGoods");
            com.Parameters.AddWithValue("@IdGoods", IdGoods);
            var data = Program.Database.Query(com);
            if (IsReturn)
            {
                if (data.Rows.Count != 0)
                {
                    numericUpDown1.Maximum = Int32.Parse(data.Rows[0]["Count"].ToString());
                    labelMaxCount.Text = data.Rows[0]["Count"].ToString();
                }
                else
                {
                    MessageBox.Show("Данного товара нет в наличии!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else
            {
                com = new MySqlCommand("SELECT * FROM `returnsuppliertemp` WHERE `Номер оприходования` = @Nomer AND `Номер` = @Nomer1");
                com.Parameters.AddWithValue("@Nomer", IdPosting);
                com.Parameters.AddWithValue("@Nomer1", IdGoods);
                var data1 = Program.Database.Query(com);

                var maxCount = Int32.Parse(data.Rows[0]["Count"].ToString());
                if (data1.Rows.Count != 0)
                    Count -= Int32.Parse(data1.Rows[0]["Кол-во"].ToString());
                if (maxCount < Count)
                {
                    numericUpDown1.Maximum = maxCount;
                    labelMaxCount.Text = maxCount.ToString();
                }
                else
                {
                    numericUpDown1.Maximum = Count;
                    labelMaxCount.Text = Count.ToString();
                }
            }
        }
    }
}
