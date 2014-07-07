namespace TvClientManager.Forms
{
    partial class NewCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCurrency));
            this.button1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrencyName = new System.Windows.Forms.TextBox();
            this.tbCurrencyCode = new System.Windows.Forms.TextBox();
            this.tbCurrynceCource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(121, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отменить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(6, 96);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 48);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Курс:";
            // 
            // tbCurrencyName
            // 
            this.tbCurrencyName.Location = new System.Drawing.Point(79, 10);
            this.tbCurrencyName.Name = "tbCurrencyName";
            this.tbCurrencyName.Size = new System.Drawing.Size(150, 20);
            this.tbCurrencyName.TabIndex = 11;
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.Location = new System.Drawing.Point(79, 33);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.Size = new System.Drawing.Size(150, 20);
            this.tbCurrencyCode.TabIndex = 12;
            // 
            // tbCurrynceCource
            // 
            this.tbCurrynceCource.Location = new System.Drawing.Point(79, 58);
            this.tbCurrynceCource.Name = "tbCurrynceCource";
            this.tbCurrynceCource.Size = new System.Drawing.Size(150, 20);
            this.tbCurrynceCource.TabIndex = 13;
            // 
            // NewCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 153);
            this.Controls.Add(this.tbCurrynceCource);
            this.Controls.Add(this.tbCurrencyCode);
            this.Controls.Add(this.tbCurrencyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCurrency";
            this.ShowInTaskbar = false;
            this.Text = "Новая валюта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrencyName;
        private System.Windows.Forms.TextBox tbCurrencyCode;
        private System.Windows.Forms.TextBox tbCurrynceCource;
    }
}