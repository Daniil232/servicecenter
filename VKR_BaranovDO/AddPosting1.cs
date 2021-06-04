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
    public partial class AddPosting : Form
    {
        public bool IsAdded { get; set; } = false;
        private int idTovar = -1;
        private string NameTovar = "";
        public AddPosting()
        {
            InitializeComponent();
        }
        void Initialize()
        {
            comboBoxSupplier.DataSource = Program.Database.Query("SELECT * FROM servicecenter.supplier;");
            comboBoxSupplier.ValueMember = "idSupplier";
            comboBoxSupplier.DisplayMember = "Name";

            comboBoxWarehouse.DataSource = Program.Database.Query("SELECT * FROM servicecenter.warehouse;");
            comboBoxWarehouse.ValueMember = "idWarehouse";
            comboBoxWarehouse.DisplayMember = "Name";

            //comboBoxTovar.DataSource = Program.Database.Query("SELECT * FROM servicecenter.tovar;");
            //comboBoxTovar.ValueMember = "idTovar";
            //comboBoxTovar.DisplayMember = "Name";

            //dataGridViewTovPosting.DataSource = Program.Database.Query("SELECT * FROM tovpostingservice");
            dataGridViewTovars.Columns.Add("Name", "Наименование");
            dataGridViewTovars.Columns.Add("Price", "Цена, руб");
            dataGridViewTovars.Columns.Add("Count", "Количество");
            dataGridViewTovars.Columns.Add("Summa", "Сумма, руб");

        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddClient addSupplier = new AddClient();
            addSupplier.checkBoxSupplier.Checked = true;
            addSupplier.ShowDialog();
            if (addSupplier.IsAdded)
                Initialize();
        }

        private void AddPosting_Load(object sender, EventArgs e)
        {
            Initialize();
        }


        private void buttonAddToPosting_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectTovar s = new SelectTovar();
            s.ID = idTovar;
            s.Name = NameTovar;
            s.ShowDialog();

            if (s.IsSelected)
            {
                idTovar = s.ID;
                textBoxTovar.Text = s.Name;
            }
        }
    }
}
