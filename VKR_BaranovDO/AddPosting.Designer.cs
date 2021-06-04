
namespace VKR_BaranovDO
{
    partial class AddPosting
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
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.buttonPosting = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.dateTimePickerWaybill = new System.Windows.Forms.DateTimePicker();
            this.textBoxWaybill = new System.Windows.Forms.TextBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxTovar = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.dataGridViewTovars = new System.Windows.Forms.DataGridView();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewTemp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(424, 280);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(141, 34);
            this.buttonAddTovar.TabIndex = 29;
            this.buttonAddTovar.Text = "Добавить";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click_1);
            // 
            // buttonPosting
            // 
            this.buttonPosting.Location = new System.Drawing.Point(34, 610);
            this.buttonPosting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosting.Name = "buttonPosting";
            this.buttonPosting.Size = new System.Drawing.Size(186, 46);
            this.buttonPosting.TabIndex = 28;
            this.buttonPosting.Text = "Оприходовать";
            this.buttonPosting.UseVisualStyleBackColor = true;
            this.buttonPosting.Click += new System.EventHandler(this.buttonPosting_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(445, 54);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(120, 31);
            this.buttonAddSupplier.TabIndex = 27;
            this.buttonAddSupplier.Text = "Добавить";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Наименование товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Склад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Накладная №";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Поставщик";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(35, 198);
            this.comboBoxWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(403, 28);
            this.comboBoxWarehouse.TabIndex = 18;
            // 
            // dateTimePickerWaybill
            // 
            this.dateTimePickerWaybill.Location = new System.Drawing.Point(227, 121);
            this.dateTimePickerWaybill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerWaybill.Name = "dateTimePickerWaybill";
            this.dateTimePickerWaybill.Size = new System.Drawing.Size(211, 26);
            this.dateTimePickerWaybill.TabIndex = 17;
            // 
            // textBoxWaybill
            // 
            this.textBoxWaybill.Location = new System.Drawing.Point(35, 121);
            this.textBoxWaybill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWaybill.Name = "textBoxWaybill";
            this.textBoxWaybill.Size = new System.Drawing.Size(116, 26);
            this.textBoxWaybill.TabIndex = 16;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(35, 54);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(403, 28);
            this.comboBoxSupplier.TabIndex = 15;
            // 
            // textBoxTovar
            // 
            this.textBoxTovar.Location = new System.Drawing.Point(35, 280);
            this.textBoxTovar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTovar.Name = "textBoxTovar";
            this.textBoxTovar.ReadOnly = true;
            this.textBoxTovar.Size = new System.Drawing.Size(232, 26);
            this.textBoxTovar.TabIndex = 30;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(278, 280);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(138, 32);
            this.buttonSelect.TabIndex = 31;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click_1);
            // 
            // dataGridViewTovars
            // 
            this.dataGridViewTovars.AllowUserToAddRows = false;
            this.dataGridViewTovars.AllowUserToDeleteRows = false;
            this.dataGridViewTovars.AllowUserToResizeColumns = false;
            this.dataGridViewTovars.AllowUserToResizeRows = false;
            this.dataGridViewTovars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTovars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTovars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovars.Location = new System.Drawing.Point(35, 320);
            this.dataGridViewTovars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTovars.MultiSelect = false;
            this.dataGridViewTovars.Name = "dataGridViewTovars";
            this.dataGridViewTovars.ReadOnly = true;
            this.dataGridViewTovars.RowHeadersWidth = 51;
            this.dataGridViewTovars.RowTemplate.Height = 24;
            this.dataGridViewTovars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTovars.Size = new System.Drawing.Size(901, 249);
            this.dataGridViewTovars.TabIndex = 32;
            // 
            // LabelTotal
            // 
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelTotal.Location = new System.Drawing.Point(542, 578);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(110, 30);
            this.LabelTotal.TabIndex = 34;
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(35, 578);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "Итого:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(838, 578);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 39);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewTemp
            // 
            this.dataGridViewTemp.AllowUserToAddRows = false;
            this.dataGridViewTemp.AllowUserToDeleteRows = false;
            this.dataGridViewTemp.AllowUserToResizeColumns = false;
            this.dataGridViewTemp.AllowUserToResizeRows = false;
            this.dataGridViewTemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTemp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemp.Location = new System.Drawing.Point(1586, 305);
            this.dataGridViewTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTemp.MultiSelect = false;
            this.dataGridViewTemp.Name = "dataGridViewTemp";
            this.dataGridViewTemp.ReadOnly = true;
            this.dataGridViewTemp.RowHeadersWidth = 51;
            this.dataGridViewTemp.RowTemplate.Height = 24;
            this.dataGridViewTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemp.Size = new System.Drawing.Size(416, 311);
            this.dataGridViewTemp.TabIndex = 36;
            // 
            // AddPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 690);
            this.Controls.Add(this.dataGridViewTemp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewTovars);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxTovar);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.buttonPosting);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.dateTimePickerWaybill);
            this.Controls.Add(this.textBoxWaybill);
            this.Controls.Add(this.comboBoxSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPosting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить оприходование";
            this.Load += new System.EventHandler(this.AddPosting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPosting;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.DateTimePicker dateTimePickerWaybill;
        private System.Windows.Forms.TextBox textBoxWaybill;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textBoxTovar;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridView dataGridViewTovars;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewTemp;
    }
}