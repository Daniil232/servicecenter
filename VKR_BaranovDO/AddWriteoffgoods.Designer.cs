namespace VKR_BaranovDO
{
    partial class AddWriteoffgoods
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxTovar = new System.Windows.Forms.TextBox();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewWriteoff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteoff)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1293, 545);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 39);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 545);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 67;
            this.button1.Text = "Списать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Склад";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(12, 32);
            this.comboBoxWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(403, 28);
            this.comboBoxWarehouse.TabIndex = 63;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(493, 89);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(138, 34);
            this.buttonSelect.TabIndex = 62;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxTovar
            // 
            this.textBoxTovar.Location = new System.Drawing.Point(14, 91);
            this.textBoxTovar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTovar.Name = "textBoxTovar";
            this.textBoxTovar.ReadOnly = true;
            this.textBoxTovar.Size = new System.Drawing.Size(470, 26);
            this.textBoxTovar.TabIndex = 61;
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(638, 89);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(141, 34);
            this.buttonAddTovar.TabIndex = 60;
            this.buttonAddTovar.Text = "Добавить";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Наименование товара";
            // 
            // dataGridViewWriteoff
            // 
            this.dataGridViewWriteoff.AllowUserToAddRows = false;
            this.dataGridViewWriteoff.AllowUserToDeleteRows = false;
            this.dataGridViewWriteoff.AllowUserToResizeColumns = false;
            this.dataGridViewWriteoff.AllowUserToResizeRows = false;
            this.dataGridViewWriteoff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWriteoff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewWriteoff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriteoff.Location = new System.Drawing.Point(14, 130);
            this.dataGridViewWriteoff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewWriteoff.MultiSelect = false;
            this.dataGridViewWriteoff.Name = "dataGridViewWriteoff";
            this.dataGridViewWriteoff.ReadOnly = true;
            this.dataGridViewWriteoff.RowHeadersWidth = 51;
            this.dataGridViewWriteoff.RowTemplate.Height = 24;
            this.dataGridViewWriteoff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWriteoff.Size = new System.Drawing.Size(1378, 408);
            this.dataGridViewWriteoff.TabIndex = 58;
            // 
            // AddWriteoffgoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 600);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxTovar);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewWriteoff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddWriteoffgoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить списание";
            this.Load += new System.EventHandler(this.AddWriteoffgoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxTovar;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewWriteoff;
    }
}