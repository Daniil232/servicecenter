
namespace VKR_BaranovDO
{
    partial class AddTovars
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxTovar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTovars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(402, 158);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(112, 32);
            this.buttonAddTovar.TabIndex = 20;
            this.buttonAddTovar.Text = "Добавить";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(280, 158);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(112, 32);
            this.buttonSelect.TabIndex = 19;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxTovar
            // 
            this.textBoxTovar.Location = new System.Drawing.Point(24, 158);
            this.textBoxTovar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTovar.Name = "textBoxTovar";
            this.textBoxTovar.ReadOnly = true;
            this.textBoxTovar.Size = new System.Drawing.Size(246, 26);
            this.textBoxTovar.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Товар";
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Items.AddRange(new object[] {
            "Ремонтная",
            "Розничная"});
            this.comboBoxPrice.Location = new System.Drawing.Point(216, 99);
            this.comboBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(180, 28);
            this.comboBoxPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(26, 99);
            this.comboBoxWarehouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(180, 28);
            this.comboBoxWarehouse.TabIndex = 14;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Склад";
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
            this.dataGridViewTovars.Location = new System.Drawing.Point(26, 198);
            this.dataGridViewTovars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTovars.MultiSelect = false;
            this.dataGridViewTovars.Name = "dataGridViewTovars";
            this.dataGridViewTovars.ReadOnly = true;
            this.dataGridViewTovars.RowHeadersWidth = 51;
            this.dataGridViewTovars.RowTemplate.Height = 24;
            this.dataGridViewTovars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTovars.Size = new System.Drawing.Size(1134, 374);
            this.dataGridViewTovars.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Товары / Материалы";
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.Location = new System.Drawing.Point(26, 579);
            this.buttonWriteOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(112, 32);
            this.buttonWriteOff.TabIndex = 21;
            this.buttonWriteOff.Text = "Списать";
            this.buttonWriteOff.UseVisualStyleBackColor = true;
            this.buttonWriteOff.Click += new System.EventHandler(this.buttonWriteOff_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1047, 579);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 32);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddTovars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 692);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonWriteOff);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxTovar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTovars);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTovars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать Товары/Материалы";
            this.Load += new System.EventHandler(this.AddTovars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxTovar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWriteOff;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewTovars;
    }
}