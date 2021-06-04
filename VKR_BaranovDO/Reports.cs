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
using Word = Microsoft.Office.Interop.Word;

namespace VKR_BaranovDO
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            comboBoxReport.SelectedIndex = 0;

            var data = Program.Database.Query("SELECT * FROM status");
            data.Rows.Add(null, "Все статусы");
            comboBoxStatus.DataSource = data;
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.ValueMember = "idStatus";

            
            data = Program.Database.Query("SELECT * FROM warehouse");
            data.Rows.Add(null,"Все склады");
            comboBoxWarehouse.DataSource = data;
            comboBoxWarehouse.DisplayMember = "Name";
            comboBoxWarehouse.ValueMember = "idWarehouse";

            SetTime();
            button1_Click(sender, e);

            comboBoxReport_SelectedIndexChanged(sender, e);
        }

        public void SetTime()
        {
            var mounth = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var date = new DateTime(year, mounth, 1);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Value = date;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker2.Value = DateTime.Now;
        }

        public void VisibleFalse()
        {
            labelOt.Visible = false;
            labelDo.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void comboBoxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            var com = new MySqlCommand();
            labelWarehouse.Visible = false;
            comboBoxWarehouse.Visible = false;

            labelStatus.Visible = false;
            comboBoxStatus.Visible = false;

            buttonSelectDate.Visible = false;

            switch (comboBoxReport.Text)
            {
                case "Остатки":
                    labelWarehouse.Visible = true;
                    comboBoxWarehouse.Visible = true;
                    VisibleFalse();
                    if (comboBoxWarehouse.Text == "Все склады")
                    {
                        dataGridViewReport.DataSource = Program.Database.Query("SELECT * FROM goodsinstockreport");
                    }
                    else
                    {
                        com = new MySqlCommand("SELECT * FROM goodsinstockreport WHERE `Склад` = @Warehouse");
                        com.Parameters.AddWithValue("@Warehouse", comboBoxWarehouse.Text);
                        dataGridViewReport.DataSource = Program.Database.Query(com);
                    }
                    break;
                case "Исполнители":
                    buttonSelectDate.Visible = true;

                    if (!labelOt.Visible)
                        dataGridViewReport.DataSource = Program.Database.Query("SELECT * FROM executorreport");
                    else
                    {
                        com = new MySqlCommand("SELECT a.* FROM executorreport AS a, servicecenter.order WHERE `DateAccepted` BETWEEN @Date1 AND @Date2 group by `Имя`");
                        com.Parameters.AddWithValue("@Date1", dateTimePicker1.Value);
                        com.Parameters.AddWithValue("@Date2", dateTimePicker2.Value);
                        dataGridViewReport.DataSource = Program.Database.Query(com);
                    }
                    //dataGridViewReport.CurrentCell = null;
                    //foreach (DataGridViewRow row in dataGridViewReport.Rows)
                    //{
                    //    if (row.Cells["Работы на сумму"].Value.ToString() == "0")
                    //    { 
                    //        row.Visible = false;
                    //    }
                    //}
                    break;

                case "Заказы по статусу":
                    labelStatus.Visible = true;
                    comboBoxStatus.Visible = true;
                    buttonSelectDate.Visible = true;
                    if (!labelOt.Visible)
                    {
                        if (comboBoxStatus.Text == "Все статусы")
                        {
                            dataGridViewReport.DataSource = Program.Database.Query("SELECT * FROM `orderstatusreport`");
                        }
                        else
                        {
                            com = new MySqlCommand("SELECT * FROM orderstatusreport WHERE `Статус заказа` = @Status");
                            com.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
                            dataGridViewReport.DataSource = Program.Database.Query(com);
                        }
                    }
                    else
                    {
                        if (comboBoxStatus.Text == "Все статусы")
                        {
                            com = new MySqlCommand("SELECT * FROM `orderstatusreport` WHERE `Дата принятия` BETWEEN @Date1 AND @Date2");
                            com.Parameters.AddWithValue("@Date1", dateTimePicker1.Value);
                            com.Parameters.AddWithValue("@Date2", dateTimePicker2.Value);
                            dataGridViewReport.DataSource = Program.Database.Query(com);
                        }
                        else
                        {
                            com = new MySqlCommand("SELECT * FROM orderstatusreport WHERE `Статус заказа` = @Status AND `Дата принятия` BETWEEN @Date1 AND @Date2");
                            com.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
                            com.Parameters.AddWithValue("@Date1", dateTimePicker1.Value);
                            com.Parameters.AddWithValue("@Date2", dateTimePicker2.Value);
                            dataGridViewReport.DataSource = Program.Database.Query(com);
                        }
                    }

                    break;

                case "Клиенты":
                    buttonSelectDate.Visible = true;

                    if (!labelOt.Visible)
                        dataGridViewReport.DataSource = Program.Database.Query("SELECT * FROM clientreport");
                    else
                    {
                        com = new MySqlCommand("SELECT a.* FROM clientreport AS a, servicecenter.order WHERE `DateAccepted` BETWEEN @Date1 AND @Date2 group by `Имя клиента`");
                        com.Parameters.AddWithValue("@Date1", dateTimePicker1.Value);
                        com.Parameters.AddWithValue("@Date2", dateTimePicker2.Value);
                        dataGridViewReport.DataSource = Program.Database.Query(com);
                    }
                    //dataGridViewReport.CurrentCell = null;
                    //foreach (DataGridViewRow row in dataGridViewReport.Rows)
                    //{
                    //    if (row.Cells["Работ на сумму"].Value.ToString() == "0")
                    //    {
                    //        row.Visible = false;
                    //    }
                    //}
                    break;
            }

                
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxReport_SelectedIndexChanged(sender, e);
        }

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxReport_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelOt.Visible)
            {
                labelOt.Visible = false;
                labelDo.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                comboBoxReport_SelectedIndexChanged(sender, e);
            }
            else
            {
                labelOt.Visible = true;
                labelDo.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                SetTime();
                comboBoxReport_SelectedIndexChanged(sender, e);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.Rows.Count == 0)
            {
                MessageBox.Show("Данные таблицы пусты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Font.Size = 16;
            oPara1.Range.Text = "Отчет по таблице " + comboBoxReport.Text;
            oPara1.Format.SpaceAfter = 24;
            oPara1.Range.InsertParagraphAfter();
            oPara1.Range.Font.Size = 11;

            Word.Paragraph oPara2;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            if (comboBoxReport.Text == "Клиенты" && labelOt.Visible)
            {
                oPara2.Range.Text = "C " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " до " + dateTimePicker2.Value.ToString("dd/MM/yyyy");
            }
            if (comboBoxReport.Text == "Исполнители" && labelOt.Visible)
            {
                oPara2.Range.Text = "C " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " до " + dateTimePicker2.Value.ToString("dd/MM/yyyy");
            }
            if (labelOt.Visible && comboBoxStatus.Visible)
            {
                oPara2.Range.Text = "Статус заказа: " + comboBoxStatus.Text + ". C " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " до " + dateTimePicker2.Value.ToString("dd/MM/yyyy");
            }
            if (!labelOt.Visible && comboBoxStatus.Visible)
            {
                oPara2.Range.Text = "Статус заказа: " + comboBoxStatus.Text;
            }
            if (comboBoxWarehouse.Visible)
            {
                oPara2.Range.Text = "Склад: " + comboBoxWarehouse.Text;
            }
            oPara2.Format.SpaceAfter = 24;
            oPara2.Range.InsertParagraphAfter();

            int r = dataGridViewReport.Rows.Count + 1, c = dataGridViewReport.Columns.Count;
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, r, c, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (i == 1)
                    {
                        oTable.Cell(1, j).Range.Text = dataGridViewReport.Columns[j - 1].HeaderCell.Value.ToString();
                    }
                    else
                    {
                        oTable.Cell(i, j).Range.Text = dataGridViewReport.Rows[i - 2].Cells[j - 1].Value.ToString();
                    }

                }
                oTable.Cell(i, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oTable.set_Style("Сетка таблицы");

            Word.Table oTable1;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable1 = oDoc.Tables.Add(wrdRng, 1, c, ref oMissing, ref oMissing);
            oTable1.Range.ParagraphFormat.SpaceAfter = 6;

            switch (comboBoxReport.Text)
            {
                case "Остатки":
                    oTable1.Cell(1, 2).Range.Text = "Кол-во: (" + dataGridViewReport.Rows.Count.ToString() + ")";
                    oTable1.Cell(1, 3).Range.Text = "ВСЕГО: " + CalculateAmount("Кол-во").ToString();
                    oTable1.Cell(1, 4).Range.Text = "ВСЕГО: " + CalculateAmount("Цена ремонтная").ToString();
                    oTable1.Cell(1, 5).Range.Text = "ВСЕГО: " + CalculateAmount("Цена розничная").ToString();
                    break;
                case "Заказы по статусу":
                    oTable1.Cell(1, 9).Range.Text = "Итого: " + CalculateAmount("Цена").ToString();
                    break;
                default:
                    oTable1.Cell(1, 2).Range.Text = "Итого: " + CalculateAmount("Работ на сумму").ToString();
                    oTable1.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
            }

            oTable1.Rows[1].Range.Font.Bold = 1;
            //oTable1.set_Style("Сетка таблицы");
        }

        public int CalculateAmount(string lineName)
        {
            int summa = 0;
            foreach (DataGridViewRow row in dataGridViewReport.Rows)
            {
                if (row.Cells[lineName].Value != null)
                    summa += Int32.Parse(row.Cells[lineName].Value.ToString());
            }
            return summa;
        }
    }
}
