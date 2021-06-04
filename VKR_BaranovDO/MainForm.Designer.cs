namespace VKR_BaranovDO
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonExecutors = new System.Windows.Forms.Button();
            this.buttonManagers = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(33, 556);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(504, 62);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWarehouse.Location = new System.Drawing.Point(33, 85);
            this.buttonWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(504, 71);
            this.buttonWarehouse.TabIndex = 2;
            this.buttonWarehouse.Text = "Склад";
            this.buttonWarehouse.UseVisualStyleBackColor = false;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClients.Location = new System.Drawing.Point(33, 160);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(504, 62);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(33, 19);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(504, 62);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers.Location = new System.Drawing.Point(33, 358);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(504, 62);
            this.buttonUsers.TabIndex = 5;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonExecutors
            // 
            this.buttonExecutors.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonExecutors.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecutors.Location = new System.Drawing.Point(33, 226);
            this.buttonExecutors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExecutors.Name = "buttonExecutors";
            this.buttonExecutors.Size = new System.Drawing.Size(504, 62);
            this.buttonExecutors.TabIndex = 6;
            this.buttonExecutors.Text = "Иcполнители";
            this.buttonExecutors.UseVisualStyleBackColor = false;
            this.buttonExecutors.Click += new System.EventHandler(this.buttonExecutors_Click);
            // 
            // buttonManagers
            // 
            this.buttonManagers.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManagers.Location = new System.Drawing.Point(33, 292);
            this.buttonManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.Size = new System.Drawing.Size(504, 62);
            this.buttonManagers.TabIndex = 7;
            this.buttonManagers.Text = "Менеджеры";
            this.buttonManagers.UseVisualStyleBackColor = false;
            this.buttonManagers.Click += new System.EventHandler(this.buttonManagers_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.Location = new System.Drawing.Point(33, 424);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(504, 62);
            this.buttonReport.TabIndex = 8;
            this.buttonReport.Text = "Отчеты";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeUser.Location = new System.Drawing.Point(33, 490);
            this.buttonChangeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(504, 62);
            this.buttonChangeUser.TabIndex = 10;
            this.buttonChangeUser.Text = "Сменить пользователя";
            this.buttonChangeUser.UseVisualStyleBackColor = false;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 656);
            this.Controls.Add(this.buttonChangeUser);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonManagers);
            this.Controls.Add(this.buttonExecutors);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.buttonOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonExecutors;
        private System.Windows.Forms.Button buttonManagers;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonChangeUser;
    }
}