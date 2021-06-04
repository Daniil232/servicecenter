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
    public partial class LookMoving : Form
    {
        public string NameMoving { get; set; } = "";
        public int IdMoving { get; set; } = -1;
        public string DateMoving { get; set; } = "";
        public string NameWarehouse1 { get; set; } = "";
        public string NameWarehouse2 { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public LookMoving()
        {
            InitializeComponent();
        }

        private void LookMoving_Load(object sender, EventArgs e)
        {
            labelMovingName.Text = "Номер перемещения: " + NameMoving;
            labelDate.Text = DateMoving;
            labelWarehouse1.Text = NameWarehouse1;
            labelWarehouse2.Text = NameWarehouse2;
            labelEmployee.Text = EmployeeName;

            var com = new MySqlCommand("SELECT * FROM tovmovingservice WHERE `Номер перемещения` = @Nomer");
            com.Parameters.AddWithValue("@Nomer", IdMoving);
            dataGridViewTovars.DataSource = Program.Database.Query(com);

            dataGridViewTovars.Columns["Номер перемещения"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            oPara1.Range.Text = "Передвижение товаров № " + NameMoving + " от " + DateMoving;
            oPara1.Format.SpaceAfter = 24;
            oPara1.Range.InsertParagraphAfter();
            oPara1.Range.Font.Size = 11;


            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Со склада: " + labelWarehouse1.Text;
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "На склад: " + labelWarehouse2.Text;
            oPara3.Range.InsertParagraphAfter();


            Word.Paragraph oPara4;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara4.Range.Text = "Сотрудник: " + labelEmployee.Text;
            oPara4.Format.SpaceAfter = 24;
            oPara4.Range.InsertParagraphAfter();
            oPara4.Format.SpaceAfter = 24;

            int r = dataGridViewTovars.Rows.Count + 1, c = dataGridViewTovars.Columns.Count, count = 1;
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
                    }
                    else
                    {
                        if (j != 1)
                        {
                            oTable.Cell(i, j).Range.Text = dataGridViewTovars.Rows[i - 2].Cells[j - 1].Value.ToString();
                        }
                        else
                        {
                            oTable.Cell(i, 1).Range.Text = count.ToString();
                            count++;
                        }

                    }

                }
                oTable.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oTable.Cell(i, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oTable.Cell(i, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oTable.set_Style("Сетка таблицы");

            Word.Table oTable1;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable1 = oDoc.Tables.Add(wrdRng, 1, c, ref oMissing, ref oMissing);
            oTable1.Range.ParagraphFormat.SpaceAfter = 6;
            oTable1.Cell(1, 3).Range.Text = "Кол-во: (" + dataGridViewTovars.Rows.Count.ToString() + ")";
            oTable1.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oTable1.set_Style("Сетка таблицы");
        }
    }
}
