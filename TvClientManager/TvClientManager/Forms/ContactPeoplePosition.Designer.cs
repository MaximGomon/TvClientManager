namespace TvClientManager.Forms
{
    partial class ContactPeoplePosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactPeoplePosition));
            this.lvPositions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsExecutorsActivity = new System.Windows.Forms.ToolStrip();
            this.tsbNewPosition = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletePosition = new System.Windows.Forms.ToolStripButton();
            this.tsbEditPosition = new System.Windows.Forms.ToolStripButton();
            this.tsExecutorsActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPositions
            // 
            this.lvPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPositions.GridLines = true;
            this.lvPositions.Location = new System.Drawing.Point(0, 25);
            this.lvPositions.Name = "lvPositions";
            this.lvPositions.Size = new System.Drawing.Size(296, 220);
            this.lvPositions.TabIndex = 5;
            this.lvPositions.UseCompatibleStateImageBehavior = false;
            this.lvPositions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 226;
            // 
            // tsExecutorsActivity
            // 
            this.tsExecutorsActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewPosition,
            this.tsbDeletePosition,
            this.tsbEditPosition});
            this.tsExecutorsActivity.Location = new System.Drawing.Point(0, 0);
            this.tsExecutorsActivity.Name = "tsExecutorsActivity";
            this.tsExecutorsActivity.Size = new System.Drawing.Size(296, 25);
            this.tsExecutorsActivity.TabIndex = 4;
            this.tsExecutorsActivity.Text = "toolStrip1";
            // 
            // tsbNewPosition
            // 
            this.tsbNewPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewPosition.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPosition.Image")));
            this.tsbNewPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPosition.Name = "tsbNewPosition";
            this.tsbNewPosition.Size = new System.Drawing.Size(23, 22);
            this.tsbNewPosition.Text = "toolStripButton1";
            // 
            // tsbDeletePosition
            // 
            this.tsbDeletePosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletePosition.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletePosition.Image")));
            this.tsbDeletePosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletePosition.Name = "tsbDeletePosition";
            this.tsbDeletePosition.Size = new System.Drawing.Size(23, 22);
            this.tsbDeletePosition.Text = "toolStripButton1";
            // 
            // tsbEditPosition
            // 
            this.tsbEditPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditPosition.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditPosition.Image")));
            this.tsbEditPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditPosition.Name = "tsbEditPosition";
            this.tsbEditPosition.Size = new System.Drawing.Size(23, 22);
            this.tsbEditPosition.Text = "toolStripButton1";
            // 
            // ContactPeoplePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 245);
            this.Controls.Add(this.lvPositions);
            this.Controls.Add(this.tsExecutorsActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactPeoplePosition";
            this.Text = "Должности";
            this.tsExecutorsActivity.ResumeLayout(false);
            this.tsExecutorsActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPositions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip tsExecutorsActivity;
        private System.Windows.Forms.ToolStripButton tsbNewPosition;
        private System.Windows.Forms.ToolStripButton tsbDeletePosition;
        private System.Windows.Forms.ToolStripButton tsbEditPosition;
    }
}