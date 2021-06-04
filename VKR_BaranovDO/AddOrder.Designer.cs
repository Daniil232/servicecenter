namespace VKR_BaranovDO
{
    partial class AddOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.buttonSelectProduct = new System.Windows.Forms.Button();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMalfunction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(216, 32);
            this.textBoxClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(257, 22);
            this.textBoxClient.TabIndex = 1;
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(493, 31);
            this.buttonSelectClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(93, 25);
            this.buttonSelectClient.TabIndex = 2;
            this.buttonSelectClient.Text = "Выбрать";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.buttonSelectClient_Click);
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.Location = new System.Drawing.Point(493, 65);
            this.buttonSelectProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(93, 25);
            this.buttonSelectProduct.TabIndex = 4;
            this.buttonSelectProduct.Text = "Выбрать";
            this.buttonSelectProduct.UseVisualStyleBackColor = true;
            this.buttonSelectProduct.Click += new System.EventHandler(this.buttonSelectProduct_Click);
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(216, 70);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.ReadOnly = true;
            this.textBoxProduct.Size = new System.Drawing.Size(257, 22);
            this.textBoxProduct.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Изделие";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 20, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата готовности";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(477, 377);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(109, 36);
            this.buttonCreateOrder.TabIndex = 10;
            this.buttonCreateOrder.Text = "Создать";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Location = new System.Drawing.Point(216, 151);
            this.textBoxEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEquipment.Multiline = true;
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.Size = new System.Drawing.Size(369, 58);
            this.textBoxEquipment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Комплектация";
            // 
            // textBoxMalfunction
            // 
            this.textBoxMalfunction.Location = new System.Drawing.Point(216, 215);
            this.textBoxMalfunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMalfunction.Multiline = true;
            this.textBoxMalfunction.Name = "textBoxMalfunction";
            this.textBoxMalfunction.Size = new System.Drawing.Size(369, 58);
            this.textBoxMalfunction.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Неисправность";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(216, 292);
            this.comboBoxManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(369, 24);
            this.comboBoxManager.TabIndex = 8;
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(216, 335);
            this.comboBoxExecutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(369, 24);
            this.comboBoxExecutor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Менеджер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Исполнитель";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.textBoxMalfunction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEquipment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSelectProduct);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectClient);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button buttonSelectClient;
        private System.Windows.Forms.Button buttonSelectProduct;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.TextBox textBoxEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMalfunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}