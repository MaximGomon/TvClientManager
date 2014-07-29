namespace TvClientManager.UserControls
{
    partial class TabServices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabServices));
            this.templateListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgSort = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.prefTextBox = new System.Windows.Forms.TextBox();
            this.prefToolStrip = new System.Windows.Forms.ToolStrip();
            this.addStripButton = new System.Windows.Forms.ToolStripButton();
            this.editStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelStripButton = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.prefToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // templateListView
            // 
            this.templateListView.CheckBoxes = true;
            this.templateListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.templateListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateListView.FullRowSelect = true;
            this.templateListView.GridLines = true;
            this.templateListView.HideSelection = false;
            this.templateListView.Location = new System.Drawing.Point(0, 0);
            this.templateListView.MultiSelect = false;
            this.templateListView.Name = "templateListView";
            this.templateListView.Size = new System.Drawing.Size(423, 352);
            this.templateListView.SmallImageList = this.imgSort;
            this.templateListView.TabIndex = 0;
            this.templateListView.UseCompatibleStateImageBehavior = false;
            this.templateListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "C";
            this.columnHeader1.Text = "Код";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "N";
            this.columnHeader2.Text = "Услуга";
            this.columnHeader2.Width = 500;
            // 
            // imgSort
            // 
            this.imgSort.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSort.ImageStream")));
            this.imgSort.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSort.Images.SetKeyName(0, "sort_desc.png");
            this.imgSort.Images.SetKeyName(1, "sort_asc_alt.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.templateListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.prefToolStrip);
            this.splitContainer1.Size = new System.Drawing.Size(675, 352);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.prefTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView1);
            this.splitContainer2.Size = new System.Drawing.Size(248, 327);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 4;
            // 
            // prefTextBox
            // 
            this.prefTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefTextBox.Location = new System.Drawing.Point(0, 0);
            this.prefTextBox.Name = "prefTextBox";
            this.prefTextBox.Size = new System.Drawing.Size(248, 20);
            this.prefTextBox.TabIndex = 2;
            // 
            // prefToolStrip
            // 
            this.prefToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripButton,
            this.deleteStripButton,
            this.editStripButton,
            this.saveStripButton,
            this.cancelStripButton});
            this.prefToolStrip.Location = new System.Drawing.Point(0, 0);
            this.prefToolStrip.Name = "prefToolStrip";
            this.prefToolStrip.Size = new System.Drawing.Size(248, 25);
            this.prefToolStrip.TabIndex = 0;
            this.prefToolStrip.Text = "toolStrip1";
            // 
            // addStripButton
            // 
            this.addStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addStripButton.Image")));
            this.addStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addStripButton.Name = "addStripButton";
            this.addStripButton.Size = new System.Drawing.Size(23, 22);
            this.addStripButton.Text = "Добавить";
            // 
            // editStripButton
            // 
            this.editStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
            this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editStripButton.Name = "editStripButton";
            this.editStripButton.Size = new System.Drawing.Size(23, 22);
            this.editStripButton.Text = "Изменить";
            // 
            // deleteStripButton
            // 
            this.deleteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
            this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteStripButton.Name = "deleteStripButton";
            this.deleteStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteStripButton.Text = "Удалить";
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveStripButton.Text = "OK";
            // 
            // cancelStripButton
            // 
            this.cancelStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelStripButton.Image")));
            this.cancelStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelStripButton.Name = "cancelStripButton";
            this.cancelStripButton.Size = new System.Drawing.Size(23, 22);
            this.cancelStripButton.Text = "Отменить";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 298);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Значения";
            this.columnHeader3.Width = 237;
            // 
            // TabServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TabServices";
            this.Size = new System.Drawing.Size(675, 352);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.prefToolStrip.ResumeLayout(false);
            this.prefToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView templateListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imgSort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox prefTextBox;
        private System.Windows.Forms.ToolStrip prefToolStrip;
        private System.Windows.Forms.ToolStripButton addStripButton;
        private System.Windows.Forms.ToolStripButton editStripButton;
        private System.Windows.Forms.ToolStripButton deleteStripButton;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripButton cancelStripButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
