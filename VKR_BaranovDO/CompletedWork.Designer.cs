
namespace VKR_BaranovDO
{
    partial class CompletedWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCompletedWork = new System.Windows.Forms.DataGridView();
            this.buttonEditCompletedWork = new System.Windows.Forms.Button();
            this.buttonDeleteCompleted = new System.Windows.Forms.Button();
            this.buttonAddCompleted = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSeal = new System.Windows.Forms.ComboBox();
            this.buttonSeal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelNameProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedWork)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotal
            // 
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelTotal.Location = new System.Drawing.Point(528, 531);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(110, 30);
            this.LabelTotal.TabIndex = 48;
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(21, 531);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 30);
            this.label6.TabIndex = 47;
            this.label6.Text = "Итого:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewCompletedWork
            // 
            this.dataGridViewCompletedWork.AllowUserToAddRows = false;
            this.dataGridViewCompletedWork.AllowUserToDeleteRows = false;
            this.dataGridViewCompletedWork.AllowUserToResizeColumns = false;
            this.dataGridViewCompletedWork.AllowUserToResizeRows = false;
            this.dataGridViewCompletedWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCompletedWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewCompletedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompletedWork.Location = new System.Drawing.Point(23, 285);
            this.dataGridViewCompletedWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCompletedWork.MultiSelect = false;
            this.dataGridViewCompletedWork.Name = "dataGridViewCompletedWork";
            this.dataGridViewCompletedWork.ReadOnly = true;
            this.dataGridViewCompletedWork.RowHeadersWidth = 51;
            this.dataGridViewCompletedWork.RowTemplate.Height = 24;
            this.dataGridViewCompletedWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompletedWork.Size = new System.Drawing.Size(1097, 242);
            this.dataGridViewCompletedWork.TabIndex = 46;
            // 
            // buttonEditCompletedWork
            // 
            this.buttonEditCompletedWork.Location = new System.Drawing.Point(1153, 560);
            this.buttonEditCompletedWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditCompletedWork.Name = "buttonEditCompletedWork";
            this.buttonEditCompletedWork.Size = new System.Drawing.Size(102, 42);
            this.buttonEditCompletedWork.TabIndex = 45;
            this.buttonEditCompletedWork.Text = "Редактировать";
            this.buttonEditCompletedWork.UseVisualStyleBackColor = true;
            this.buttonEditCompletedWork.Visible = false;
            this.buttonEditCompletedWork.Click += new System.EventHandler(this.buttonEditCompletedWork_Click);
            // 
            // buttonDeleteCompleted
            // 
            this.buttonDeleteCompleted.Location = new System.Drawing.Point(502, 571);
            this.buttonDeleteCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCompleted.Name = "buttonDeleteCompleted";
            this.buttonDeleteCompleted.Size = new System.Drawing.Size(136, 42);
            this.buttonDeleteCompleted.TabIndex = 44;
            this.buttonDeleteCompleted.Text = "Удалить";
            this.buttonDeleteCompleted.UseVisualStyleBackColor = true;
            this.buttonDeleteCompleted.Click += new System.EventHandler(this.buttonDeleteCompleted_Click);
            // 
            // buttonAddCompleted
            // 
            this.buttonAddCompleted.Location = new System.Drawing.Point(456, 248);
            this.buttonAddCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCompleted.Name = "buttonAddCompleted";
            this.buttonAddCompleted.Size = new System.Drawing.Size(117, 31);
            this.buttonAddCompleted.TabIndex = 43;
            this.buttonAddCompleted.Text = "Добавить";
            this.buttonAddCompleted.UseVisualStyleBackColor = true;
            this.buttonAddCompleted.Click += new System.EventHandler(this.buttonAddCompleted_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(579, 250);
            this.buttonAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(136, 31);
            this.buttonAddService.TabIndex = 42;
            this.buttonAddService.Text = "+ Новый";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 32);
            this.button2.TabIndex = 41;
            this.button2.Text = "Выбрать со склада";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Товары / Материалы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Виды работ";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(21, 246);
            this.comboBoxService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(427, 28);
            this.comboBoxService.TabIndex = 38;
            this.comboBoxService.TextChanged += new System.EventHandler(this.comboBoxService_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(21, 571);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 42);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.Location = new System.Drawing.Point(15, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(99, 39);
            this.labelOrder.TabIndex = 49;
            this.labelOrder.Text = "Заказ";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(23, 184);
            this.comboBoxExecutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(427, 28);
            this.comboBoxExecutor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Исполнитель";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(23, 128);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(426, 28);
            this.comboBoxStatus.TabIndex = 52;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Статус заказа";
            // 
            // comboBoxSeal
            // 
            this.comboBoxSeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeal.FormattingEnabled = true;
            this.comboBoxSeal.Items.AddRange(new object[] {
            "Акт выполненных работ",
            "Приемная квитанция"});
            this.comboBoxSeal.Location = new System.Drawing.Point(860, 128);
            this.comboBoxSeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSeal.Name = "comboBoxSeal";
            this.comboBoxSeal.Size = new System.Drawing.Size(257, 28);
            this.comboBoxSeal.TabIndex = 54;
            // 
            // buttonSeal
            // 
            this.buttonSeal.Location = new System.Drawing.Point(997, 169);
            this.buttonSeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeal.Name = "buttonSeal";
            this.buttonSeal.Size = new System.Drawing.Size(122, 32);
            this.buttonSeal.TabIndex = 55;
            this.buttonSeal.Text = "Печать";
            this.buttonSeal.UseVisualStyleBackColor = true;
            this.buttonSeal.Click += new System.EventHandler(this.buttonSeal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Печать";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(456, 128);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(202, 31);
            this.buttonOrder.TabIndex = 57;
            this.buttonOrder.Text = "Заказать запачасти";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Location = new System.Drawing.Point(19, 60);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(199, 20);
            this.labelNameProduct.TabIndex = 58;
            this.labelNameProduct.Text = "Наименование изделия: ";
            // 
            // CompletedWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 689);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSeal);
            this.Controls.Add(this.comboBoxSeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.dataGridViewCompletedWork);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddCompleted);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.buttonDeleteCompleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditCompletedWork);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompletedWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнененная работа по заказу";
            this.Load += new System.EventHandler(this.CompletedWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEditCompletedWork;
        private System.Windows.Forms.Button buttonDeleteCompleted;
        private System.Windows.Forms.Button buttonAddCompleted;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCompletedWork;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSeal;
        private System.Windows.Forms.Button buttonSeal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelNameProduct;
    }
}