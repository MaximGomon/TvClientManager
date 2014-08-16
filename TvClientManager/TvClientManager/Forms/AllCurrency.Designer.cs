namespace TvClientManager.Forms
{
    partial class AllCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCurrency));
            this.tsExecutorsActivity = new System.Windows.Forms.ToolStrip();
            this.tsbNewCurrency = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteCurrency = new System.Windows.Forms.ToolStripButton();
            this.tsbEditCurrency = new System.Windows.Forms.ToolStripButton();
            this.lvCurrencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsExecutorsActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsExecutorsActivity
            // 
            this.tsExecutorsActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewCurrency,
            this.tsbDeleteCurrency,
            this.tsbEditCurrency});
            this.tsExecutorsActivity.Location = new System.Drawing.Point(0, 0);
            this.tsExecutorsActivity.Name = "tsExecutorsActivity";
            this.tsExecutorsActivity.Size = new System.Drawing.Size(279, 25);
            this.tsExecutorsActivity.TabIndex = 2;
            this.tsExecutorsActivity.Text = "toolStrip1";
            // 
            // tsbNewCurrency
            // 
            this.tsbNewCurrency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCurrency.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCurrency.Image")));
            this.tsbNewCurrency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCurrency.Name = "tsbNewCurrency";
            this.tsbNewCurrency.Size = new System.Drawing.Size(23, 22);
            this.tsbNewCurrency.Text = "toolStripButton1";
            // 
            // tsbDeleteCurrency
            // 
            this.tsbDeleteCurrency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteCurrency.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteCurrency.Image")));
            this.tsbDeleteCurrency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCurrency.Name = "tsbDeleteCurrency";
            this.tsbDeleteCurrency.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteCurrency.Text = "toolStripButton1";
            // 
            // tsbEditCurrency
            // 
            this.tsbEditCurrency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditCurrency.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditCurrency.Image")));
            this.tsbEditCurrency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditCurrency.Name = "tsbEditCurrency";
            this.tsbEditCurrency.Size = new System.Drawing.Size(23, 22);
            this.tsbEditCurrency.Text = "toolStripButton1";
            // 
            // lvCurrencies
            // 
            this.lvCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCurrencies.GridLines = true;
            this.lvCurrencies.Location = new System.Drawing.Point(0, 25);
            this.lvCurrencies.Name = "lvCurrencies";
            this.lvCurrencies.Size = new System.Drawing.Size(279, 221);
            this.lvCurrencies.TabIndex = 3;
            this.lvCurrencies.UseCompatibleStateImageBehavior = false;
            this.lvCurrencies.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "Курс";
            // 
            // Currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 246);
            this.Controls.Add(this.lvCurrencies);
            this.Controls.Add(this.tsExecutorsActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Currencies";
            this.Text = "Валюты";
            this.tsExecutorsActivity.ResumeLayout(false);
            this.tsExecutorsActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsExecutorsActivity;
        private System.Windows.Forms.ToolStripButton tsbNewCurrency;
        private System.Windows.Forms.ToolStripButton tsbDeleteCurrency;
        private System.Windows.Forms.ToolStripButton tsbEditCurrency;
        private System.Windows.Forms.ListView lvCurrencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;

    }
}