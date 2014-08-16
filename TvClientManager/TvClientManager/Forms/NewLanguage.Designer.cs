namespace TvClientManager.Forms
{
    partial class NewLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLanguage));
            this.tbCurrencyCode = new System.Windows.Forms.TextBox();
            this.tbCurrencyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbIsDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.Location = new System.Drawing.Point(78, 29);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.Size = new System.Drawing.Size(150, 20);
            this.tbCurrencyCode.TabIndex = 20;
            // 
            // tbCurrencyName
            // 
            this.tbCurrencyName.Location = new System.Drawing.Point(78, 6);
            this.tbCurrencyName.Name = "tbCurrencyName";
            this.tbCurrencyName.Size = new System.Drawing.Size(150, 20);
            this.tbCurrencyName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Код:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название:";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(120, 92);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 48);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Отменить";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(5, 92);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 48);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Сохранить";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbIsDefault
            // 
            this.cbIsDefault.AutoSize = true;
            this.cbIsDefault.Location = new System.Drawing.Point(78, 55);
            this.cbIsDefault.Name = "cbIsDefault";
            this.cbIsDefault.Size = new System.Drawing.Size(99, 17);
            this.cbIsDefault.TabIndex = 22;
            this.cbIsDefault.Text = "По умолчанию";
            this.cbIsDefault.UseVisualStyleBackColor = true;
            // 
            // NewLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 150);
            this.Controls.Add(this.cbIsDefault);
            this.Controls.Add(this.tbCurrencyCode);
            this.Controls.Add(this.tbCurrencyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLanguage";
            this.Text = "Новый язык";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrencyCode;
        private System.Windows.Forms.TextBox tbCurrencyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbIsDefault;
    }
}