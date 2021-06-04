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
using System.Reflection;

namespace VKR_BaranovDO
{
    public partial class CompletedWork : Form
    {
        public bool IsChanged { get; set; } = false;
        public int IdOrder { get; set; } = -1;
        public int IdStatus { get; set; } = -1;
        public int IdExecutor { get; set; } = -1;
        public int IdProduct { get; set; } = -1;
        public bool IsSelected { get; set; } = false;
        public string NameClient { get; set; } = "";
        public string NameManager { get; set; } = "";
        public string NameOrderProduct { get; set; } = "";

        public CompletedWork()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            comboBoxService.DataSource = Program.Database.Query("Select * FROM serviceservice");
            comboBoxService.ValueMember = "Номер услуги";
            comboBoxService.DisplayMember = "Наименование";

            comboBoxExecutor.DataSource = Program.Database.Query("Select * FROM executor");
            comboBoxExecutor.ValueMember = "idExecutor";
            comboBoxExecutor.DisplayMember = "Name";

            var com = new MySqlCommand("SELECT * FROM completedworkservice WHERE `Номер заказа` = @Order;");
            com.Parameters.AddWithValue("@Order", IdOrder);
            dataGridViewCompletedWork.DataSource = Program.Database.Query(com);

            dataGridViewCompletedWork.Columns["Номер заказа"].Visible = false;
            dataGridViewCompletedWork.Columns["Номер выполненной работы"].Visible = false;
            dataGridViewCompletedWork.Columns["Номер товара на складе"].Visible = false;

            RefreshTotalPrice();
        }

        public void RefreshTotalPrice ()
        {
            var total = 0;
            var price = 0;
            var count = 0;
            foreach (DataGridViewRow row in dataGridViewCompletedWork.Rows)
            {
                if (row.Cells["Кол-во"].Value != null)
                    count = (int)row.Cells["Кол-во"].Value;
                if (row.Cells["Цена"].Value != null)
                    price = (int)row.Cells["Цена"].Value;
                total += count * price;
            }

            LabelTotal.Text = total.ToString();
        }

        private void buttonAddCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                var com = new MySqlCommand("SELECT Name, Price FROM service WHERE `idService` = @idService;");
                com.Parameters.AddWithValue("@idService", comboBoxService.SelectedValue);
                var table = Program.Database.Query(com);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали вид работы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
                com = new MySqlCommand("CALL AddCompletedWork(@OrderId, @Name, @Price, @Count, @GoodsId)");
                com.Parameters.AddWithValue("@OrderId", IdOrder);
                com.Parameters.AddWithValue("@Name", table.Rows[0]["Name"].ToString());
                com.Parameters.AddWithValue("@Price", Int32.Parse(table.Rows[0]["Price"].ToString()));
                com.Parameters.AddWithValue("@Count", 1);
                com.Parameters.AddWithValue("@GoodsId", null);
                Program.Database.Query(com);

                com = new MySqlCommand("CALL EditStatus(@OrderId, @StatusId)");
                com.Parameters.AddWithValue("@OrderId", IdOrder);
                com.Parameters.AddWithValue("@StatusId", 2);
                Program.Database.Query(com);

                Initialize();
                EditOrderPrice();
                comboBoxStatus.SelectedValue = 2;
                MessageBox.Show("Запись успешно добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCompeletedWork addCompeletedWork = new AddCompeletedWork();
            addCompeletedWork.IdOrder = IdOrder;
            addCompeletedWork.ShowDialog();

            if (addCompeletedWork.IsAdded)
            {
                Initialize();
                EditOrderPrice();
                comboBoxStatus.SelectedValue = 2;
            }
        }

        public void EditOrderPrice()
        {
            var com = new MySqlCommand("CALL EditOrderPrice(@OrderId, @Price)");
            com.Parameters.AddWithValue("@OrderId", IdOrder);
            com.Parameters.AddWithValue("@Price", Int32.Parse(LabelTotal.Text));
            Program.Database.Query(com);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { 
            var com = new MySqlCommand("CALL EditStatusExecutor(@OrderId, @StatusId, @ExecutorId)");
            com.Parameters.AddWithValue("@OrderId", IdOrder);
            com.Parameters.AddWithValue("@StatusId", comboBoxStatus.SelectedValue);
            com.Parameters.AddWithValue("@ExecutorId", comboBoxExecutor.SelectedValue);
            Program.Database.Query(com);
            EditOrderPrice();
            IsChanged = true;
            this.Close();
        }

        private void buttonEditCompletedWork_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompletedWork.SelectedRows.Count > 0)
            {
                EditCompletedWork g = new EditCompletedWork();

                g.IdCompletedWork = (int)dataGridViewCompletedWork.SelectedRows[0].Cells["Номер выполненной работы"].Value;
                g.Count = (int)dataGridViewCompletedWork.SelectedRows[0].Cells["Кол-во"].Value;
                g.Price = (int)dataGridViewCompletedWork.SelectedRows[0].Cells["Цена"].Value;
                g.Initialize();
                g.ShowDialog();

                Initialize();
                EditOrderPrice();
            }
        }

        private void buttonDeleteCompleted_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompletedWork.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (dataGridViewCompletedWork.SelectedRows[0].Cells["Номер товара на складе"].Value !=  null)
                        {
                            var com1 = new MySqlCommand("CALL EditGoodsInStockPlus(@Count, @GoodsInStockId)");
                            com1.Parameters.AddWithValue("@Count", dataGridViewCompletedWork.SelectedRows[0].Cells["Кол-во"].Value);
                            com1.Parameters.AddWithValue("@GoodsInStockId", dataGridViewCompletedWork.SelectedRows[0].Cells["Номер товара на складе"].Value);
                            Program.Database.Query(com1);
                        }
                        

                        var com = new MySqlCommand("CALL DeleteCompletedWork(@CompletedWorkId)");
                        com.Parameters.AddWithValue("@CompletedWorkId", dataGridViewCompletedWork.SelectedRows[0].Cells["Номер выполненной работы"].Value);
                        Program.Database.Query(com);
                        MessageBox.Show("Запись успешно удалена", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Initialize();
                        EditOrderPrice();
                    }

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CompletedWork_Load(object sender, EventArgs e)
        {
            labelOrder.Text = "Заказ № " + IdOrder.ToString();
            labelNameProduct.Text = "Наименование изделия: " + NameOrderProduct.ToString();

            Initialize();

            comboBoxStatus.DataSource = Program.Database.Query("SELECT * FROM servicecenter.status");
            comboBoxStatus.ValueMember = "idStatus";
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.SelectedIndex = IdStatus - 1;

            comboBoxService.DataSource = Program.Database.Query("SELECT * FROM serviceservice");
            comboBoxService.ValueMember = "Номер услуги";
            comboBoxService.DisplayMember = "Наименование";
            comboBoxService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxService.AutoCompleteSource = AutoCompleteSource.ListItems;


            comboBoxExecutor.DataSource = Program.Database.Query("SELECT * FROM executor");
            comboBoxExecutor.ValueMember = "idExecutor";
            comboBoxExecutor.DisplayMember = "Name";
            comboBoxExecutor.SelectedIndex = IdExecutor - 1;

            comboBoxSeal.SelectedIndex = 0;

            if (!Program.User.IsAdmin)
            {
                label5.Visible = false;
                buttonSeal.Visible = false;
                comboBoxSeal.Visible = false;
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTovars g = new AddTovars();
            g.idOrder = IdOrder;
            g.ShowDialog();
            if (g.IsAdded == true)
            {
                Initialize();
                EditOrderPrice();
            }
        }

        private void buttonSeal_Click(object sender, EventArgs e)
        {
            var com = new MySqlCommand("SELECT * FROM productsservice WHERE `Номер изделия` = @idProduct");
            com.Parameters.AddWithValue("idProduct", IdProduct);
            var tableProduct = Program.Database.Query(com);

            com = new MySqlCommand("SELECT * FROM servicecenter.order WHERE idOrder = @idOrder");
            com.Parameters.AddWithValue("idOrder", IdOrder);
            var tableOrder = Program.Database.Query(com);

            com = new MySqlCommand("SELECT * FROM servicecenter.client WHERE idClient = @idClient");
            com.Parameters.AddWithValue("idClient", tableOrder.Rows[0]["ClientId"]);
            var tableClient = Program.Database.Query(com);

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            if (comboBoxSeal.Text == "Приемная квитанция")
            {
                int i = 0;
                while (i < 2)
                {
                    Word.Paragraph oPara1;
                    oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = "Приёмная квитанция № " + IdOrder.ToString() + " от " + tableOrder.Rows[0]["DateAccepted"].ToString();

                    oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.InsertParagraphAfter();
                    oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                    Word.Table oTable;
                    Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oTable = oDoc.Tables.Add(wrdRng, 4, 2, ref oMissing, ref oMissing);
                    oTable.Range.ParagraphFormat.SpaceAfter = 6;

                    int r, c;
                    string strText;
                    for (r = 1; r <= 4; r++)
                        for (c = 1; c <= 2; c++)
                        {
                            strText = "r" + r + "c" + c;
                            if (r == 1 && c == 1)
                                oTable.Cell(r, c).Range.Text = "Клиент: " + tableClient.Rows[0]["Name"].ToString();
                            if (r == 2 && c == 1)
                                oTable.Cell(r, c).Range.Text = "Устройство: " + tableProduct.Rows[0]["Наименование"].ToString();
                            if (r == 3 && c == 1)
                                oTable.Cell(r, c).Range.Text = "Серийный номер: " + tableProduct.Rows[0]["IMEI"].ToString();
                            if (r == 4 && c == 1)
                                oTable.Cell(r, c).Range.Text = "Неисправность: " + tableOrder.Rows[0]["Malfunction"].ToString();
                            if (r == 1 && c == 2)
                                oTable.Cell(r, c).Range.Text = "Дата готовности: " + tableOrder.Rows[0]["DateReadiness"].ToString();
                        }

                    Word.Paragraph oPara2;
                    object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara2.Format.SpaceAfter = 24;

                    wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oTable = oDoc.Tables.Add(wrdRng, 1, 2, ref oMissing, ref oMissing);
                    oTable.Range.ParagraphFormat.SpaceAfter = 6;
                    for (c = 1; c <= 2; c++)
                    {
                        oTable.Cell(1, 1).Range.Text = "Приемщик: ________________ " + NameManager;
                        oTable.Cell(1, 2).Range.Text = "____________________ " + tableClient.Rows[0]["Name"].ToString();
                    }

                    Word.Paragraph oPara3;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara3.Format.SpaceAfter = 24;
                    oPara3.Format.SpaceBefore = 24;
                    oPara3.Range.Text = "";
                    oPara3.Range.InsertParagraphAfter();
                    oPara3.Range.InsertParagraphBefore();

                    i++;
                }
            }

            else
            {

                Word.Paragraph oPara1;
                oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = "Акт выполненных работ № " + IdOrder.ToString();

                oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oPara1.Format.SpaceAfter = 24;
                oPara1.Range.InsertParagraphAfter();
                oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                Word.Paragraph oPara2;
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara2.Range.Text = "Клиентy: " + tableClient.Rows[0]["Name"].ToString();
                oPara2.Format.SpaceAfter = 6;
                oPara2.Range.InsertParagraphAfter();

                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara3.Range.Text = "Устройство: " + tableProduct.Rows[0]["Наименование"].ToString();
                oPara3.Format.SpaceAfter = 6;
                oPara3.Range.InsertParagraphAfter();

                Word.Paragraph oPara4;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara4.Range.Text = "Серийный номер: " + tableProduct.Rows[0]["IMEI"].ToString();
                oPara4.Format.SpaceAfter = 6;
                oPara4.Range.InsertParagraphAfter();
                oPara4.Range.InsertParagraphAfter();

                Word.Paragraph oPara5;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara5.Range.Text = "Неисправность:  " + tableOrder.Rows[0]["Malfunction"].ToString();
                oPara5.Format.SpaceAfter = 6;
                oPara5.Range.InsertParagraphAfter();
                oPara5.Range.InsertParagraphBefore();

                int r = dataGridViewCompletedWork.Rows.Count + 1, c = dataGridViewCompletedWork.Columns.Count - 3;
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
                            oTable.Cell(1, 1).Range.Text = "Наименование";
                            oTable.Cell(1, 2).Range.Text = "Кол-во";
                            oTable.Cell(1, 3).Range.Text = "Цена";
                            oTable.Cell(1, 4).Range.Text = "Сумма";
                        }
                        else
                            oTable.Cell(i, j).Range.Text = dataGridViewCompletedWork.Rows[i - 2].Cells[j + 1].Value.ToString();
                    }
                    oTable.Cell(i, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                }

                oTable.Rows[1].Range.Font.Bold = 1;
                oTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oTable.set_Style("Сетка таблицы");

                Word.Paragraph oPara6;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara6.Range.Text = "Итого: " + LabelTotal.Text;
                oPara6.Format.SpaceBefore = 6;
                oPara6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                oPara6.Range.InsertParagraphAfter();

                Word.Paragraph oPara7;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara7 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara7.Range.Text = "К оплате: " + LabelTotal.Text;

            }

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text == "Ждет запчасть")
                buttonOrder.Visible = true;
            else
                buttonOrder.Visible = false;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            WaitingTovar g = new WaitingTovar();
            g.idOrder = IdOrder;
            g.ShowDialog();
        }

        private void comboBoxService_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
