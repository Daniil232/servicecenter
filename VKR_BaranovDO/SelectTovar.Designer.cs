
namespace VKR_BaranovDO
{
    partial class SelectTovar
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
            this.dataGridViewTovars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTemp = new System.Windows.Forms.DataGridView();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Location = new System.Drawing.Point(908, 529);
            this.buttonAddTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(201, 52);
            this.buttonAddTovar.TabIndex = 6;
            this.buttonAddTovar.Text = "+ Добавить";
            this.buttonAddTovar.UseVisualStyleBackColor = true;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(21, 529);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(112, 52);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
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
            this.dataGridViewTovars.Location = new System.Drawing.Point(21, 41);
            this.dataGridViewTovars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTovars.MultiSelect = false;
            this.dataGridViewTovars.Name = "dataGridViewTovars";
            this.dataGridViewTovars.ReadOnly = true;
            this.dataGridViewTovars.RowHeadersWidth = 51;
            this.dataGridViewTovars.RowTemplate.Height = 24;
            this.dataGridViewTovars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTovars.Size = new System.Drawing.Size(1088, 481);
            this.dataGridViewTovars.TabIndex = 4;
            this.dataGridViewTovars.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewTovars_RowsAdded);
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
            this.dataGridViewTemp.Location = new System.Drawing.Point(1459, 18);
            this.dataGridViewTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTemp.MultiSelect = false;
            this.dataGridViewTemp.Name = "dataGridViewTemp";
            this.dataGridViewTemp.ReadOnly = true;
            this.dataGridViewTemp.RowHeadersWidth = 51;
            this.dataGridViewTemp.RowTemplate.Height = 24;
            this.dataGridViewTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemp.Size = new System.Drawing.Size(439, 270);
            this.dataGridViewTemp.TabIndex = 7;
            // 
            // textBoxSeach
            // 
            this.textBoxSeach.Location = new System.Drawing.Point(79, 8);
            this.textBoxSeach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSeach.Name = "textBoxSeach";
            this.textBoxSeach.Size = new System.Drawing.Size(202, 26);
            this.textBoxSeach.TabIndex = 8;
            this.textBoxSeach.TextChanged += new System.EventHandler(this.textBoxSeach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(327, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(273, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Показать только необходимые";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(139, 526);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(206, 52);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // SelectTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 601);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSeach);
            this.Controls.Add(this.dataGridViewTemp);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewTovars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор Товара/Материала";
            this.Load += new System.EventHandler(this.SelectTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridView dataGridViewTovars;
        private System.Windows.Forms.DataGridView dataGridViewTemp;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonEdit;
    }
}