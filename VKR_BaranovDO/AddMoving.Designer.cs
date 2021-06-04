namespace VKR_BaranovDO
{
    partial class AddMoving
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
            this.dataGridViewMoving = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxTovar = new System.Windows.Forms.TextBox();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWarehouseFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWarehouseInto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoving)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMoving
            // 
            this.dataGridViewMoving.AllowUserToAddRows = false;
            this.dataGridViewMoving.AllowUserToDeleteRows = false;
            this.dataGridViewMoving.AllowUserToResizeColumns = false;
            this.dataGridViewMoving.AllowUserToResizeRows = false;
            this.dataGridViewMoving.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMoving.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewMoving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoving.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewMoving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMoving.MultiSelect = false;
            this.dataGridViewMoving.Name = "dataGridViewMoving";
            this.dataGridViewMoving.ReadOnly = true;
            this.dataGridViewMoving.RowHeadersWidth = 51;
            this.dataGridViewMoving.RowTemplate.Height = 24;
            this.dataGridViewMoving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMoving.Size = new System.Drawing.Size(1225, 326);
            this.dataGridViewMoving.TabIndex = 47;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(438, 85);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(123, 27);
            this.buttonSelect.TabIndex = 51;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxTovar
            // 
            this.textBoxTovar.Location = new System.Drawing.Point(12, 87);
            this.textBoxTovar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTovar.Name = "textBoxTovar";
            this.textBoxTovar.ReadOnly = true;
            this.textBoxTovar.Size = new System.Drawing.Size(418, 22);
            this.textBoxTovar.TabIndex = 50;
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(567, 85);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(125, 27);
            this.buttonAddTovar.TabIndex = 49;
            this.buttonAddTovar.Text = "Добавить";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Наименование товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Склад";
            // 
            // comboBoxWarehouseFrom
            // 
            this.comboBoxWarehouseFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouseFrom.FormattingEnabled = true;
            this.comboBoxWarehouseFrom.Location = new System.Drawing.Point(11, 40);
            this.comboBoxWarehouseFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWarehouseFrom.Name = "comboBoxWarehouseFrom";
            this.comboBoxWarehouseFrom.Size = new System.Drawing.Size(359, 24);
            this.comboBoxWarehouseFrom.TabIndex = 52;
            this.comboBoxWarehouseFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouseFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "На склад";
            // 
            // comboBoxWarehouseInto
            // 
            this.comboBoxWarehouseInto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouseInto.FormattingEnabled = true;
            this.comboBoxWarehouseInto.Location = new System.Drawing.Point(415, 40);
            this.comboBoxWarehouseInto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWarehouseInto.Name = "comboBoxWarehouseInto";
            this.comboBoxWarehouseInto.Size = new System.Drawing.Size(359, 24);
            this.comboBoxWarehouseInto.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 56;
            this.button1.Text = "Переместить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1149, 450);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 31);
            this.buttonDelete.TabIndex = 57;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddMoving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 507);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWarehouseInto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxWarehouseFrom);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxTovar);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewMoving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddMoving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить перемещение";
            this.Load += new System.EventHandler(this.AddMoving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMoving;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxTovar;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWarehouseFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWarehouseInto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelete;
    }
}