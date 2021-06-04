namespace VKR_BaranovDO
{
    partial class AddProduct
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
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxIMEI = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonBrand = new System.Windows.Forms.Button();
            this.buttonModel = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(342, 318);
            this.textBoxState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxState.Size = new System.Drawing.Size(248, 123);
            this.textBoxState.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Серийный номер / IMEI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Бренд";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Модель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Цвет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Состояние";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(342, 166);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(248, 28);
            this.comboBoxGroup.TabIndex = 3;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(342, 200);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(248, 28);
            this.comboBoxBrand.TabIndex = 5;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(342, 241);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(248, 28);
            this.comboBoxModel.TabIndex = 7;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(494, 448);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(99, 45);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Создать";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxIMEI
            // 
            this.textBoxIMEI.Location = new System.Drawing.Point(342, 131);
            this.textBoxIMEI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIMEI.Name = "textBoxIMEI";
            this.textBoxIMEI.Size = new System.Drawing.Size(248, 26);
            this.textBoxIMEI.TabIndex = 2;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(342, 281);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(248, 26);
            this.textBoxColor.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Владелец";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(598, 166);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(32, 32);
            this.buttonAddGroup.TabIndex = 4;
            this.buttonAddGroup.Text = "+";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonBrand
            // 
            this.buttonBrand.Location = new System.Drawing.Point(598, 201);
            this.buttonBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrand.Name = "buttonBrand";
            this.buttonBrand.Size = new System.Drawing.Size(32, 32);
            this.buttonBrand.TabIndex = 6;
            this.buttonBrand.Text = "+";
            this.buttonBrand.UseVisualStyleBackColor = true;
            this.buttonBrand.Click += new System.EventHandler(this.buttonBrand_Click);
            // 
            // buttonModel
            // 
            this.buttonModel.Location = new System.Drawing.Point(598, 238);
            this.buttonModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModel.Name = "buttonModel";
            this.buttonModel.Size = new System.Drawing.Size(32, 32);
            this.buttonModel.TabIndex = 8;
            this.buttonModel.Text = "+";
            this.buttonModel.UseVisualStyleBackColor = true;
            this.buttonModel.Click += new System.EventHandler(this.buttonModel_Click);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Enabled = false;
            this.textBoxClient.Location = new System.Drawing.Point(342, 94);
            this.textBoxClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(248, 26);
            this.textBoxClient.TabIndex = 0;
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(598, 88);
            this.buttonSelectClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(99, 38);
            this.buttonSelectClient.TabIndex = 1;
            this.buttonSelectClient.Text = "Выбрать";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.buttonSelectClient_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 562);
            this.Controls.Add(this.buttonSelectClient);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.buttonModel);
            this.Controls.Add(this.buttonBrand);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxIMEI);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить изделие";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxIMEI;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonBrand;
        private System.Windows.Forms.Button buttonModel;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button buttonSelectClient;
    }
}