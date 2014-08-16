namespace TvClientManager.Forms
{
    partial class AllLanguages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllLanguages));
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsExecutorsActivity = new System.Windows.Forms.ToolStrip();
            this.tsbNewLanguage = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteLanguage = new System.Windows.Forms.ToolStripButton();
            this.tsbEditLanguage = new System.Windows.Forms.ToolStripButton();
            this.tsExecutorsActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLanguages
            // 
            this.lvLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.lvLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLanguages.GridLines = true;
            this.lvLanguages.Location = new System.Drawing.Point(0, 25);
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(284, 236);
            this.lvLanguages.TabIndex = 5;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            // 
            // tsExecutorsActivity
            // 
            this.tsExecutorsActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewLanguage,
            this.tsbDeleteLanguage,
            this.tsbEditLanguage});
            this.tsExecutorsActivity.Location = new System.Drawing.Point(0, 0);
            this.tsExecutorsActivity.Name = "tsExecutorsActivity";
            this.tsExecutorsActivity.Size = new System.Drawing.Size(284, 25);
            this.tsExecutorsActivity.TabIndex = 4;
            this.tsExecutorsActivity.Text = "toolStrip1";
            // 
            // tsbNewLanguage
            // 
            this.tsbNewLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewLanguage.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewLanguage.Image")));
            this.tsbNewLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewLanguage.Name = "tsbNewLanguage";
            this.tsbNewLanguage.Size = new System.Drawing.Size(23, 22);
            this.tsbNewLanguage.Text = "toolStripButton1";
            // 
            // tsbDeleteLanguage
            // 
            this.tsbDeleteLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteLanguage.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteLanguage.Image")));
            this.tsbDeleteLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteLanguage.Name = "tsbDeleteLanguage";
            this.tsbDeleteLanguage.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteLanguage.Text = "toolStripButton1";
            // 
            // tsbEditLanguage
            // 
            this.tsbEditLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditLanguage.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditLanguage.Image")));
            this.tsbEditLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditLanguage.Name = "tsbEditLanguage";
            this.tsbEditLanguage.Size = new System.Drawing.Size(23, 22);
            this.tsbEditLanguage.Text = "toolStripButton1";
            // 
            // Languages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lvLanguages);
            this.Controls.Add(this.tsExecutorsActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Languages";
            this.Text = "Языки";
            this.tsExecutorsActivity.ResumeLayout(false);
            this.tsExecutorsActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLanguages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip tsExecutorsActivity;
        private System.Windows.Forms.ToolStripButton tsbNewLanguage;
        private System.Windows.Forms.ToolStripButton tsbDeleteLanguage;
        private System.Windows.Forms.ToolStripButton tsbEditLanguage;
    }
}