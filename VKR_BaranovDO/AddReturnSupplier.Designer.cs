namespace VKR_BaranovDO
{
    partial class AddReturnSupplier
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
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPostingName = new System.Windows.Forms.Label();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.buttonReturnSupplier = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewTemp = new System.Windows.Forms.DataGridView();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.dataGridViewTemp1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarehouse.Location = new System.Drawing.Point(187, 129);
            this.labelWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(62, 21);
            this.labelWarehouse.TabIndex = 11;
            this.labelWarehouse.Text = "label6";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplier.Location = new System.Drawing.Point(187, 83);
            this.labelSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(62, 21);
            this.labelSupplier.TabIndex = 10;
            this.labelSupplier.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Склад: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поставщик: ";
            // 
            // labelPostingName
            // 
            this.labelPostingName.AutoSize = true;
            this.labelPostingName.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.labelPostingName.Location = new System.Drawing.Point(13, 9);
            this.labelPostingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostingName.Name = "labelPostingName";
            this.labelPostingName.Size = new System.Drawing.Size(103, 40);
            this.labelPostingName.TabIndex = 7;
            this.labelPostingName.Text = "label1";
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.AllowUserToAddRows = false;
            this.dataGridViewReturn.AllowUserToDeleteRows = false;
            this.dataGridViewReturn.AllowUserToResizeColumns = false;
            this.dataGridViewReturn.AllowUserToResizeRows = false;
            this.dataGridViewReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReturn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(20, 167);
            this.dataGridViewReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReturn.MultiSelect = false;
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.ReadOnly = true;
            this.dataGridViewReturn.RowHeadersWidth = 51;
            this.dataGridViewReturn.RowTemplate.Height = 24;
            this.dataGridViewReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturn.Size = new System.Drawing.Size(1158, 311);
            this.dataGridViewReturn.TabIndex = 18;
            // 
            // buttonReturnSupplier
            // 
            this.buttonReturnSupplier.Location = new System.Drawing.Point(20, 485);
            this.buttonReturnSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReturnSupplier.Name = "buttonReturnSupplier";
            this.buttonReturnSupplier.Size = new System.Drawing.Size(188, 35);
            this.buttonReturnSupplier.TabIndex = 19;
            this.buttonReturnSupplier.Text = "Вернуть";
            this.buttonReturnSupplier.UseVisualStyleBackColor = true;
            this.buttonReturnSupplier.Click += new System.EventHandler(this.buttonReturnSupplier_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(990, 485);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(188, 35);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
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
            this.dataGridViewTemp.Location = new System.Drawing.Point(1602, 113);
            this.dataGridViewTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTemp.MultiSelect = false;
            this.dataGridViewTemp.Name = "dataGridViewTemp";
            this.dataGridViewTemp.ReadOnly = true;
            this.dataGridViewTemp.RowHeadersWidth = 51;
            this.dataGridViewTemp.RowTemplate.Height = 24;
            this.dataGridViewTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemp.Size = new System.Drawing.Size(51, 100);
            this.dataGridViewTemp.TabIndex = 21;
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(215, 485);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(141, 35);
            this.buttonAddTovar.TabIndex = 50;
            this.buttonAddTovar.Text = "Редактировать";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // dataGridViewTemp1
            // 
            this.dataGridViewTemp1.AllowUserToAddRows = false;
            this.dataGridViewTemp1.AllowUserToDeleteRows = false;
            this.dataGridViewTemp1.AllowUserToResizeColumns = false;
            this.dataGridViewTemp1.AllowUserToResizeRows = false;
            this.dataGridViewTemp1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTemp1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTemp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemp1.Location = new System.Drawing.Point(1602, 241);
            this.dataGridViewTemp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTemp1.MultiSelect = false;
            this.dataGridViewTemp1.Name = "dataGridViewTemp1";
            this.dataGridViewTemp1.ReadOnly = true;
            this.dataGridViewTemp1.RowHeadersWidth = 51;
            this.dataGridViewTemp1.RowTemplate.Height = 24;
            this.dataGridViewTemp1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemp1.Size = new System.Drawing.Size(51, 100);
            this.dataGridViewTemp1.TabIndex = 51;
            // 
            // AddReturnSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 599);
            this.Controls.Add(this.dataGridViewTemp1);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.dataGridViewTemp);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReturnSupplier);
            this.Controls.Add(this.dataGridViewReturn);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPostingName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddReturnSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый возврат поставщику";
            this.Load += new System.EventHandler(this.AddReturnSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPostingName;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.Button buttonReturnSupplier;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.DataGridView dataGridViewTemp;
        private System.Windows.Forms.Button buttonAddTovar;
        public System.Windows.Forms.DataGridView dataGridViewTemp1;
    }
}