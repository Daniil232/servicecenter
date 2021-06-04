
namespace VKR_BaranovDO
{
    partial class SelectCountAndPrice
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRepair = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRetail = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.labelRepair = new System.Windows.Forms.Label();
            this.labelRetail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShowPrice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelNeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 90);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(260, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Закупочная цена";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(213, 167);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Location = new System.Drawing.Point(228, 233);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(108, 27);
            this.buttonSave1.TabIndex = 6;
            this.buttonSave1.Text = "Сохранить";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Текущая цена, руб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Расчетная цена, руб";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ремонтная";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Розничная";
            // 
            // numericUpDownRepair
            // 
            this.numericUpDownRepair.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRepair.Location = new System.Drawing.Point(181, 60);
            this.numericUpDownRepair.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRepair.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownRepair.Name = "numericUpDownRepair";
            this.numericUpDownRepair.Size = new System.Drawing.Size(132, 22);
            this.numericUpDownRepair.TabIndex = 11;
            // 
            // numericUpDownRetail
            // 
            this.numericUpDownRetail.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRetail.Location = new System.Drawing.Point(181, 112);
            this.numericUpDownRetail.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRetail.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownRetail.Name = "numericUpDownRetail";
            this.numericUpDownRetail.Size = new System.Drawing.Size(132, 22);
            this.numericUpDownRetail.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelRepair
            // 
            this.labelRepair.AutoSize = true;
            this.labelRepair.Location = new System.Drawing.Point(480, 65);
            this.labelRepair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepair.Name = "labelRepair";
            this.labelRepair.Size = new System.Drawing.Size(16, 17);
            this.labelRepair.TabIndex = 14;
            this.labelRepair.Text = "0";
            // 
            // labelRetail
            // 
            this.labelRetail.AutoSize = true;
            this.labelRetail.Location = new System.Drawing.Point(480, 117);
            this.labelRetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRetail.Name = "labelRetail";
            this.labelRetail.Size = new System.Drawing.Size(16, 17);
            this.labelRetail.TabIndex = 15;
            this.labelRetail.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRetail);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.labelRepair);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownRetail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownRepair);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(29, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 228);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // buttonShowPrice
            // 
            this.buttonShowPrice.Location = new System.Drawing.Point(359, 139);
            this.buttonShowPrice.Name = "buttonShowPrice";
            this.buttonShowPrice.Size = new System.Drawing.Size(211, 42);
            this.buttonShowPrice.TabIndex = 5;
            this.buttonShowPrice.Text = "Показать розничные цены";
            this.buttonShowPrice.UseVisualStyleBackColor = true;
            this.buttonShowPrice.Click += new System.EventHandler(this.buttonShowPrice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(73, 184);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 16;
            // 
            // labelNeed
            // 
            this.labelNeed.AutoSize = true;
            this.labelNeed.BackColor = System.Drawing.SystemColors.Control;
            this.labelNeed.ForeColor = System.Drawing.Color.Red;
            this.labelNeed.Location = new System.Drawing.Point(356, 95);
            this.labelNeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeed.Name = "labelNeed";
            this.labelNeed.Size = new System.Drawing.Size(0, 17);
            this.labelNeed.TabIndex = 16;
            // 
            // SelectCountAndPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 509);
            this.Controls.Add(this.labelNeed);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonShowPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectCountAndPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор кол-ва и цены";
            this.Load += new System.EventHandler(this.SelectCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownRepair;
        private System.Windows.Forms.NumericUpDown numericUpDownRetail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelRepair;
        private System.Windows.Forms.Label labelRetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonShowPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelNeed;
    }
}