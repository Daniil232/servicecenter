namespace VKR_BaranovDO
{
    partial class AddClient
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveAddClient = new System.Windows.Forms.Button();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxSupplier = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(235, 121);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(235, 232);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 26);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(235, 291);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(228, 26);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мобильный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Адрес";
            // 
            // btnSaveAddClient
            // 
            this.btnSaveAddClient.Location = new System.Drawing.Point(332, 336);
            this.btnSaveAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAddClient.Name = "btnSaveAddClient";
            this.btnSaveAddClient.Size = new System.Drawing.Size(132, 51);
            this.btnSaveAddClient.TabIndex = 4;
            this.btnSaveAddClient.Text = "Сохранить";
            this.btnSaveAddClient.UseVisualStyleBackColor = true;
            this.btnSaveAddClient.Click += new System.EventHandler(this.btnSaveAddClient_Click);
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(235, 179);
            this.maskedTextBoxTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxTelephone.Mask = "+79990000000";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(228, 26);
            this.maskedTextBoxTelephone.TabIndex = 1;
            // 
            // checkBoxSupplier
            // 
            this.checkBoxSupplier.AutoSize = true;
            this.checkBoxSupplier.Location = new System.Drawing.Point(235, 59);
            this.checkBoxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSupplier.Name = "checkBoxSupplier";
            this.checkBoxSupplier.Size = new System.Drawing.Size(121, 24);
            this.checkBoxSupplier.TabIndex = 5;
            this.checkBoxSupplier.Text = "Поставщик";
            this.checkBoxSupplier.UseVisualStyleBackColor = true;
            this.checkBoxSupplier.CheckedChanged += new System.EventHandler(this.checkBoxSupplier_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(470, 232);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 13;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(332, 336);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 51);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 471);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.checkBoxSupplier);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.btnSaveAddClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить контрагента";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveAddClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        public System.Windows.Forms.CheckBox checkBoxSupplier;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonEdit;
    }
}