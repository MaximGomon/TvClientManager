namespace TvClientManager.Forms
{
    partial class NewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClient));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbExecutor = new System.Windows.Forms.ComboBox();
            this.lblExecutor = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.lblI_Currency = new System.Windows.Forms.Label();
            this.tbClientCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblI_Price = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblI_Date = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblI_Name = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lblI_Tel = new System.Windows.Forms.Label();
            this.tbUrAdress = new System.Windows.Forms.TextBox();
            this.lblI_UAdress = new System.Windows.Forms.Label();
            this.tbPostAddress = new System.Windows.Forms.TextBox();
            this.lblI_PAdress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddExecutor = new System.Windows.Forms.Button();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddCurrency = new System.Windows.Forms.Button();
            this.btAddLang = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAddLang);
            this.groupBox2.Controls.Add(this.btAddCurrency);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbFax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btAddExecutor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLanguage);
            this.groupBox2.Controls.Add(this.lblLang);
            this.groupBox2.Controls.Add(this.cbExecutor);
            this.groupBox2.Controls.Add(this.lblExecutor);
            this.groupBox2.Controls.Add(this.cbCurrency);
            this.groupBox2.Controls.Add(this.lblI_Currency);
            this.groupBox2.Controls.Add(this.tbClientCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.tbFilePath);
            this.groupBox2.Controls.Add(this.lblI_Price);
            this.groupBox2.Controls.Add(this.dtpRegistrationDate);
            this.groupBox2.Controls.Add(this.lblI_Date);
            this.groupBox2.Controls.Add(this.tbClientName);
            this.groupBox2.Controls.Add(this.lblI_Name);
            this.groupBox2.Controls.Add(this.tbTelephone);
            this.groupBox2.Controls.Add(this.lblI_Tel);
            this.groupBox2.Controls.Add(this.tbUrAdress);
            this.groupBox2.Controls.Add(this.lblI_UAdress);
            this.groupBox2.Controls.Add(this.tbPostAddress);
            this.groupBox2.Controls.Add(this.lblI_PAdress);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(690, 381);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(468, 128);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(205, 21);
            this.cbLanguage.TabIndex = 22;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(362, 135);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(38, 13);
            this.lblLang.TabIndex = 24;
            this.lblLang.Text = "Язык:";
            // 
            // cbExecutor
            // 
            this.cbExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExecutor.FormattingEnabled = true;
            this.cbExecutor.Location = new System.Drawing.Point(468, 96);
            this.cbExecutor.Name = "cbExecutor";
            this.cbExecutor.Size = new System.Drawing.Size(205, 21);
            this.cbExecutor.TabIndex = 21;
            // 
            // lblExecutor
            // 
            this.lblExecutor.AutoSize = true;
            this.lblExecutor.Location = new System.Drawing.Point(362, 103);
            this.lblExecutor.Name = "lblExecutor";
            this.lblExecutor.Size = new System.Drawing.Size(77, 13);
            this.lblExecutor.TabIndex = 23;
            this.lblExecutor.Text = "Исполнитель:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(468, 68);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(205, 21);
            this.cbCurrency.TabIndex = 19;
            // 
            // lblI_Currency
            // 
            this.lblI_Currency.AutoSize = true;
            this.lblI_Currency.Location = new System.Drawing.Point(362, 75);
            this.lblI_Currency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_Currency.Name = "lblI_Currency";
            this.lblI_Currency.Size = new System.Drawing.Size(48, 13);
            this.lblI_Currency.TabIndex = 20;
            this.lblI_Currency.Text = "Валюта:";
            // 
            // tbClientCode
            // 
            this.tbClientCode.Location = new System.Drawing.Point(135, 14);
            this.tbClientCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientCode.Name = "tbClientCode";
            this.tbClientCode.Size = new System.Drawing.Size(205, 20);
            this.tbClientCode.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Код:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(468, 13);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(205, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilePath.Location = new System.Drawing.Point(468, 38);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(205, 22);
            this.tbFilePath.TabIndex = 15;
            this.tbFilePath.Visible = false;
            // 
            // lblI_Price
            // 
            this.lblI_Price.AutoSize = true;
            this.lblI_Price.Location = new System.Drawing.Point(362, 19);
            this.lblI_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_Price.Name = "lblI_Price";
            this.lblI_Price.Size = new System.Drawing.Size(80, 13);
            this.lblI_Price.TabIndex = 10;
            this.lblI_Price.Text = "Цена в месяц:";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Location = new System.Drawing.Point(468, 156);
            this.dtpRegistrationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(205, 20);
            this.dtpRegistrationDate.TabIndex = 4;
            // 
            // lblI_Date
            // 
            this.lblI_Date.AutoSize = true;
            this.lblI_Date.Location = new System.Drawing.Point(362, 160);
            this.lblI_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_Date.Name = "lblI_Date";
            this.lblI_Date.Size = new System.Drawing.Size(103, 13);
            this.lblI_Date.TabIndex = 4;
            this.lblI_Date.Text = "Дата регистрации:";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(135, 38);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientName.Multiline = true;
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(205, 64);
            this.tbClientName.TabIndex = 0;
            // 
            // lblI_Name
            // 
            this.lblI_Name.AutoSize = true;
            this.lblI_Name.Location = new System.Drawing.Point(16, 41);
            this.lblI_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_Name.Name = "lblI_Name";
            this.lblI_Name.Size = new System.Drawing.Size(32, 13);
            this.lblI_Name.TabIndex = 0;
            this.lblI_Name.Text = "Имя:";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(135, 291);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(205, 20);
            this.tbTelephone.TabIndex = 3;
            // 
            // lblI_Tel
            // 
            this.lblI_Tel.AutoSize = true;
            this.lblI_Tel.Location = new System.Drawing.Point(16, 294);
            this.lblI_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_Tel.Name = "lblI_Tel";
            this.lblI_Tel.Size = new System.Drawing.Size(55, 13);
            this.lblI_Tel.TabIndex = 3;
            this.lblI_Tel.Text = "Телефон:";
            // 
            // tbUrAdress
            // 
            this.tbUrAdress.Location = new System.Drawing.Point(135, 198);
            this.tbUrAdress.Margin = new System.Windows.Forms.Padding(4);
            this.tbUrAdress.Multiline = true;
            this.tbUrAdress.Name = "tbUrAdress";
            this.tbUrAdress.Size = new System.Drawing.Size(205, 87);
            this.tbUrAdress.TabIndex = 2;
            // 
            // lblI_UAdress
            // 
            this.lblI_UAdress.AutoSize = true;
            this.lblI_UAdress.Location = new System.Drawing.Point(16, 198);
            this.lblI_UAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_UAdress.Name = "lblI_UAdress";
            this.lblI_UAdress.Size = new System.Drawing.Size(111, 13);
            this.lblI_UAdress.TabIndex = 2;
            this.lblI_UAdress.Text = "Юредический адрес:";
            // 
            // tbPostAddress
            // 
            this.tbPostAddress.Location = new System.Drawing.Point(135, 110);
            this.tbPostAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbPostAddress.Multiline = true;
            this.tbPostAddress.Name = "tbPostAddress";
            this.tbPostAddress.Size = new System.Drawing.Size(205, 82);
            this.tbPostAddress.TabIndex = 1;
            // 
            // lblI_PAdress
            // 
            this.lblI_PAdress.AutoSize = true;
            this.lblI_PAdress.Location = new System.Drawing.Point(16, 110);
            this.lblI_PAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI_PAdress.Name = "lblI_PAdress";
            this.lblI_PAdress.Size = new System.Drawing.Size(93, 13);
            this.lblI_PAdress.TabIndex = 1;
            this.lblI_PAdress.Text = "Почтовый адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Путь для файлов:";
            // 
            // btAddExecutor
            // 
            this.btAddExecutor.Image = ((System.Drawing.Image)(resources.GetObject("btAddExecutor.Image")));
            this.btAddExecutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddExecutor.Location = new System.Drawing.Point(363, 192);
            this.btAddExecutor.Name = "btAddExecutor";
            this.btAddExecutor.Size = new System.Drawing.Size(100, 34);
            this.btAddExecutor.TabIndex = 26;
            this.btAddExecutor.Text = "Добавить исполнитея";
            this.btAddExecutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddExecutor.UseVisualStyleBackColor = true;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(135, 319);
            this.tbFax.Margin = new System.Windows.Forms.Padding(4);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(205, 20);
            this.tbFax.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Факс:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(135, 347);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(205, 20);
            this.tbEmail.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "E-mail:";
            // 
            // btAddCurrency
            // 
            this.btAddCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btAddCurrency.Image")));
            this.btAddCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddCurrency.Location = new System.Drawing.Point(471, 192);
            this.btAddCurrency.Name = "btAddCurrency";
            this.btAddCurrency.Size = new System.Drawing.Size(100, 34);
            this.btAddCurrency.TabIndex = 31;
            this.btAddCurrency.Text = "Добавить валюту";
            this.btAddCurrency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddCurrency.UseVisualStyleBackColor = true;
            // 
            // btAddLang
            // 
            this.btAddLang.Image = ((System.Drawing.Image)(resources.GetObject("btAddLang.Image")));
            this.btAddLang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddLang.Location = new System.Drawing.Point(575, 192);
            this.btAddLang.Name = "btAddLang";
            this.btAddLang.Size = new System.Drawing.Size(100, 34);
            this.btAddLang.TabIndex = 32;
            this.btAddLang.Text = "Добавить язык";
            this.btAddLang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddLang.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(481, 401);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 48);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Сохранить";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(596, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отменить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewClient";
            this.ShowInTaskbar = false;
            this.Text = "Новый клиент";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cbExecutor;
        private System.Windows.Forms.Label lblExecutor;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lblI_Currency;
        private System.Windows.Forms.TextBox tbClientCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblI_Price;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Label lblI_Date;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lblI_Name;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lblI_Tel;
        private System.Windows.Forms.TextBox tbUrAdress;
        private System.Windows.Forms.Label lblI_UAdress;
        private System.Windows.Forms.TextBox tbPostAddress;
        private System.Windows.Forms.Label lblI_PAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddCurrency;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddExecutor;
        private System.Windows.Forms.Button btAddLang;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button1;
    }
}