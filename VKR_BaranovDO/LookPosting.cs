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
    public partial class LookPosting : Form
    {
        public string NamePosting { get; set;} = "";
        public bool IsAdded { get; set;} = false;
        public int idPosting { get; set; } = -1;
        public string NameSupplier { get; set;} = "";
        public string DatePosting { get; set;} = "";
        public string NameWarehouse { get; set;} = "";
        public string EmployeeName { get; set;} = "";
        public LookPosting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshTotal()
        {
            var total = 0;
            var price = 0;
            var count = 0;
            foreach (DataGridViewRow row in dataGridViewTovars.Rows)
            {
                if (row.Cells["Кол-во"].Value != null)
                    count = (int)row.Cells["Кол-во"].Value;
                if (row.Cells["Цена"].Value != null)
                    price = (int)row.Cells["Цена"].Value;
                total += count * price;
            }
            LabelTotal.Text = total.ToString();
        }

        private void LookPosting_Load(object sender, EventArgs e)
        {
            labelPostingName.Text = "Оприходование товаров № " + NamePosting + " от " + DatePosting;
            labelSupplier.Text = NameSupplier;
            labelWarehouse.Text = NameWarehouse;
            labelEmployee.Text = EmployeeName;

            var com = new MySqlCommand("SELECT * FROM tovpostingservice WHERE `Номер оприходования` = @Nomer");
            com.Parameters.AddWithValue("@Nomer", idPosting);
            dataGridViewTovars.DataSource = Program.Database.Query(com);

            dataGridViewTovars.Columns["Номер оприходования"].Visible = false;
            dataGridViewTovars.Columns["Номер"].Visible = false;

            RefreshTotal();
        }

        private void buttonSeal_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Font.Size = 16;
            oPara1.Range.Text = "Оприходование товаров № " + NamePosting + " от " + DatePosting;
            oPara1.Format.SpaceAfter = 24;
            oPara1.Range.InsertParagraphAfter();
            oPara1.Range.Font.Size = 11;


            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Поставщик: " + labelSupplier.Text;
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "Склад: " + labelWarehouse.Text;
            oPara3.Range.InsertParagraphAfter();

            Word.Paragraph oPara4;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara4.Range.Text = "Сотрудник: " + labelEmployee.Text;
            oPara4.Format.SpaceAfter = 24;
            oPara4.Range.InsertParagraphAfter();

            int r = dataGridViewTovars.Rows.Count + 1, c = dataGridViewTovars.Columns.Count - 1, count = 1;
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
                        oTable.Cell(1, 1).Range.Text = "№";
                        oTable.Cell(1, 2).Range.Text = "Наименование";
                        oTable.Cell(1, 3).Range.Text = "Кол-во";
                        oTable.Cell(1, 4).Range.Text = "Цена";
                        oTable.Cell(1, 5).Range.Text = "Сумма";
                    }
                    else
                    {   if (j != 1)
                        {
                            oTable.Cell(i, j).Range.Text = dataGridViewTovars.Rows[i - 2].Cells[j].Value.ToString();
                        }
                        else
                        {
                            oTable.Cell(i, 1).Range.Text = count.ToString();
                            count++;  
                        }
                    }
                }
                oTable.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oTable.Cell(i, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oTable.Cell(i, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                oTable.Cell(i, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                oTable.Cell(i, 5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                
            }

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oTable.set_Style("Сетка таблицы");

            Word.Paragraph oPara5;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara5.Range.Text = "Итого: " + LabelTotal.Text;
            oPara5.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            oPara5.Format.SpaceBefore = 6;
            oPara5.Range.InsertParagraphAfter();

            Word.Paragraph oPara6;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara6.Range.Text = "";
            oPara6.Range.InsertParagraphAfter();

            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            for (c = 1; c <= 2; c++)
            {
                oTable.Cell(1, 1).Range.Text = "Отпустил ________________________________ ";
                oTable.Cell(1, 2).Range.Text = "Получил ________________________________ ";
            }
            oTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var g = new AddReturnSupplier();
            g.NamePosting = labelPostingName.Text;
            g.NameSupplier = NameSupplier;
            g.NameWarehouse = NameWarehouse;
            g.idPosting = idPosting;
            g.ShowDialog();
            if (g.IsAdded)
                IsAdded = true;
        }
    }
}
