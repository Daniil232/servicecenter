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
    public partial class SelectTovar : Form
    {
        public int IdTovar { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameTovar { get; set; } = "";
        public int PriceRepair { get; set; } = -1;
        public int PriceRetail { get; set; } = -1;
        public bool IsPosting { get; set; } = true;
        public SelectTovar()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            dataGridViewTovars.DataSource = Program.Database.Query("SELECT * FROM tovarsservice");
            dataGridViewTemp.DataSource = Program.Database.Query("SELECT * FROM waitingtovar");

            if (IsPosting)
            {
                CellStyle();
                checkBox1.Visible = true;    
            }
            dataGridViewTovars.CurrentCell = null;
        }

        public void CellStyle()
        {
            foreach (DataGridViewRow row in dataGridViewTovars.Rows)
            {
                foreach (DataGridViewRow row1 in dataGridViewTemp.Rows)
                {
                    if ((int)row.Cells["Номер товара"].Value == (int)row1.Cells["TovarId"].Value && (int)row1.Cells["Count"].Value != 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                }
            }
        }

        private void SelectTovar_Load(object sender, EventArgs e)
        {
            Initialize();
            dataGridViewTovars.CurrentCell = null;
        }

        private void dataGridViewTovars_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount + e.RowIndex == dataGridViewTovars.Rows.Count && IdTovar != -1)
                foreach (DataGridViewRow row in dataGridViewTovars.Rows)
                {
                    if ((int)row.Cells["Номер товара"].Value == IdTovar)
                    {
                        row.Selected = true;
                    }
                }
        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            AddTovar addTovar = new AddTovar();
            addTovar.ShowDialog();

            if (addTovar.IsAdded)
                Initialize();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovars.SelectedRows.Count > 0)
            {
                IdTovar = Convert.ToInt32(dataGridViewTovars.SelectedRows[0].Cells["Номер товара"].Value);
                NameTovar = Convert.ToString(dataGridViewTovars.SelectedRows[0].Cells["Наименование"].Value);
                PriceRepair = Convert.ToInt32(dataGridViewTovars.SelectedRows[0].Cells["Цена ремонтная"].Value);
                PriceRetail = Convert.ToInt32(dataGridViewTovars.SelectedRows[0].Cells["Цена розничная"].Value);
                IsSelected = true;
                this.Close();
            }
        }

        private void textBoxSeach_TextChanged(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT * FROM `tovarsservice` WHERE `Наименование` LIKE @Name");
            com.Parameters.AddWithValue("@Name", "%" + textBoxSeach.Text + "%");
            dataGridViewTovars.DataSource = Program.Database.Query(com);
            if (IsPosting)
            {
                CellStyle();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewTovars.Rows)
                {
                    if (row.DefaultCellStyle.BackColor != Color.YellowGreen)
                    {
                        dataGridViewTovars.CurrentCell = null;
                        row.Visible = false;
                    }
                }
            }
            else 
                Initialize();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovars.SelectedRows.Count > 0)
            {
                AddTovar g = new AddTovar();
                g.idTovar = Int32.Parse(dataGridViewTovars.SelectedRows[0].Cells["Номер товара"].Value.ToString());
                g.NameTovar = dataGridViewTovars.SelectedRows[0].Cells["Наименование"].Value.ToString();
                g.Description = dataGridViewTovars.SelectedRows[0].Cells["Описание"].Value.ToString();
                g.Articyle = dataGridViewTovars.SelectedRows[0].Cells["Артикул"].Value.ToString();
                g.PriceRepair = Int32.Parse(dataGridViewTovars.SelectedRows[0].Cells["Цена ремонтная"].Value.ToString());
                g.PriceRetail = Int32.Parse(dataGridViewTovars.SelectedRows[0].Cells["Цена розничная"].Value.ToString());
                g.IsEdit = true;
                g.ShowDialog();
                if (g.IsAdded)
                    Initialize();
            }
        }
    }
}
