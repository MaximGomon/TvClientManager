﻿namespace TvClientManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClients = new System.Windows.Forms.ToolStripButton();
            this.tsbCalc = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbRecycle = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.statusToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbStatus = new System.Windows.Forms.ToolStripButton();
            this.tslStatus = new System.Windows.Forms.ToolStripLabel();
            this.scClients = new System.Windows.Forms.SplitContainer();
            this.tsClientActions = new System.Windows.Forms.ToolStrip();
            this.tsbAddClient = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveClient = new System.Windows.Forms.ToolStripButton();
            this.lvClientsList = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsClientInfoActions = new System.Windows.Forms.ToolStrip();
            this.tbsSaveClientDetails = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelSaveClientDatails = new System.Windows.Forms.ToolStripButton();
            this.tsbEditClientDetails = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.statusToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scClients)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.scClients.SuspendLayout();
            this.tsClientActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsClientInfoActions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClients,
            this.tsbCalc,
            this.toolStripButton1,
            this.tsbRecycle,
            this.tsbAbout,
            this.tsbExit});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(922, 38);
            this.tsMainMenu.TabIndex = 3;
            // 
            // tsbClients
            // 
            this.tsbClients.AutoSize = false;
            this.tsbClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClients.Image = ((System.Drawing.Image)(resources.GetObject("tsbClients.Image")));
            this.tsbClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClients.Name = "tsbClients";
            this.tsbClients.Size = new System.Drawing.Size(35, 35);
            this.tsbClients.Text = "toolStripButton1";
            this.tsbClients.ToolTipText = "Список клієнтів";
            // 
            // tsbCalc
            // 
            this.tsbCalc.AutoSize = false;
            this.tsbCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCalc.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalc.Image")));
            this.tsbCalc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalc.Name = "tsbCalc";
            this.tsbCalc.Size = new System.Drawing.Size(35, 35);
            this.tsbCalc.Text = "toolStripButton2";
            this.tsbCalc.ToolTipText = "Калькулятор";
            this.tsbCalc.Click += new System.EventHandler(this.tsbCalc_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.AutoSize = false;
            this.tsbAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(35, 35);
            this.tsbAbout.Text = "toolStripButton3";
            this.tsbAbout.ToolTipText = "Про програму";
            // 
            // tsbRecycle
            // 
            this.tsbRecycle.AutoSize = false;
            this.tsbRecycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbRecycle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecycle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecycle.Image")));
            this.tsbRecycle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRecycle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecycle.Name = "tsbRecycle";
            this.tsbRecycle.Size = new System.Drawing.Size(35, 35);
            this.tsbRecycle.Text = "toolStripButton4";
            this.tsbRecycle.ToolTipText = "Корзина";
            // 
            // tsbExit
            // 
            this.tsbExit.AutoSize = false;
            this.tsbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(35, 35);
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbExit.ToolTipText = "Вихід";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.scMain.Location = new System.Drawing.Point(0, 38);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scClients);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.splitContainer1);
            this.scMain.Size = new System.Drawing.Size(922, 413);
            this.scMain.SplitterDistance = 177;
            this.scMain.TabIndex = 4;
            // 
            // statusToolStrip
            // 
            this.statusToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStatus,
            this.tslStatus});
            this.statusToolStrip.Location = new System.Drawing.Point(0, 458);
            this.statusToolStrip.Name = "statusToolStrip";
            this.statusToolStrip.Size = new System.Drawing.Size(922, 25);
            this.statusToolStrip.TabIndex = 5;
            this.statusToolStrip.Text = "toolStrip1";
            // 
            // tsbStatus
            // 
            this.tsbStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbStatus.BackgroundImage")));
            this.tsbStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatus.Name = "tsbStatus";
            this.tsbStatus.Size = new System.Drawing.Size(23, 22);
            this.tsbStatus.ToolTipText = "Переглянути подію";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // scClients
            // 
            this.scClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scClients.Location = new System.Drawing.Point(0, 0);
            this.scClients.Name = "scClients";
            this.scClients.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scClients.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsClientActions);
            // 
            // scClients.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvClientsList);
            this.scClients.Size = new System.Drawing.Size(177, 413);
            this.scClients.SplitterDistance = 26;
            this.scClients.TabIndex = 0;
            // 
            // tsClientActions
            // 
            this.tsClientActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddClient,
            this.tsbRemoveClient});
            this.tsClientActions.Location = new System.Drawing.Point(0, 0);
            this.tsClientActions.Name = "tsClientActions";
            this.tsClientActions.Size = new System.Drawing.Size(177, 25);
            this.tsClientActions.TabIndex = 0;
            this.tsClientActions.Text = "toolStrip1";
            // 
            // tsbAddClient
            // 
            this.tsbAddClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddClient.Image")));
            this.tsbAddClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddClient.Name = "tsbAddClient";
            this.tsbAddClient.Size = new System.Drawing.Size(23, 22);
            this.tsbAddClient.Text = "toolStripButton2";
            // 
            // tsbRemoveClient
            // 
            this.tsbRemoveClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveClient.Image")));
            this.tsbRemoveClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveClient.Name = "tsbRemoveClient";
            this.tsbRemoveClient.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveClient.Text = "toolStripButton2";
            // 
            // lvClientsList
            // 
            this.lvClientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.image,
            this.Code,
            this.Name});
            this.lvClientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClientsList.FullRowSelect = true;
            this.lvClientsList.GridLines = true;
            this.lvClientsList.Location = new System.Drawing.Point(0, 0);
            this.lvClientsList.MultiSelect = false;
            this.lvClientsList.Name = "lvClientsList";
            this.lvClientsList.Size = new System.Drawing.Size(177, 383);
            this.lvClientsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvClientsList.TabIndex = 0;
            this.lvClientsList.UseCompatibleStateImageBehavior = false;
            this.lvClientsList.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Код";
            // 
            // Name
            // 
            this.Name.Text = "Название";
            // 
            // image
            // 
            this.image.Text = "";
            this.image.Width = 30;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsClientInfoActions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(741, 413);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // tsClientInfoActions
            // 
            this.tsClientInfoActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsSaveClientDetails,
            this.tsbCancelSaveClientDatails,
            this.tsbEditClientDetails});
            this.tsClientInfoActions.Location = new System.Drawing.Point(0, 0);
            this.tsClientInfoActions.Name = "tsClientInfoActions";
            this.tsClientInfoActions.Size = new System.Drawing.Size(741, 25);
            this.tsClientInfoActions.TabIndex = 0;
            this.tsClientInfoActions.Text = "toolStrip2";
            // 
            // tbsSaveClientDetails
            // 
            this.tbsSaveClientDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsSaveClientDetails.Image = ((System.Drawing.Image)(resources.GetObject("tbsSaveClientDetails.Image")));
            this.tbsSaveClientDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsSaveClientDetails.Name = "tbsSaveClientDetails";
            this.tbsSaveClientDetails.Size = new System.Drawing.Size(23, 22);
            this.tbsSaveClientDetails.Text = "toolStripButton2";
            // 
            // tsbCancelSaveClientDatails
            // 
            this.tsbCancelSaveClientDatails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelSaveClientDatails.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelSaveClientDatails.Image")));
            this.tsbCancelSaveClientDatails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelSaveClientDatails.Name = "tsbCancelSaveClientDatails";
            this.tsbCancelSaveClientDatails.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelSaveClientDatails.Text = "toolStripButton2";
            // 
            // tsbEditClientDetails
            // 
            this.tsbEditClientDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditClientDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditClientDetails.Image")));
            this.tsbEditClientDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditClientDetails.Name = "tsbEditClientDetails";
            this.tsbEditClientDetails.Size = new System.Drawing.Size(23, 22);
            this.tsbEditClientDetails.Text = "toolStripButton2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 483);
            this.Controls.Add(this.statusToolStrip);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ClientManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.statusToolStrip.ResumeLayout(false);
            this.statusToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scClients)).EndInit();
            this.scClients.ResumeLayout(false);
            this.tsClientActions.ResumeLayout(false);
            this.tsClientActions.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsClientInfoActions.ResumeLayout(false);
            this.tsClientInfoActions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsbClients;
        private System.Windows.Forms.ToolStripButton tsbCalc;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripButton tsbRecycle;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip statusToolStrip;
        private System.Windows.Forms.ToolStripButton tsbStatus;
        private System.Windows.Forms.ToolStripLabel tslStatus;
        private System.Windows.Forms.SplitContainer scClients;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tsClientInfoActions;
        private System.Windows.Forms.ToolStripButton tbsSaveClientDetails;
        private System.Windows.Forms.ToolStripButton tsbCancelSaveClientDatails;
        private System.Windows.Forms.ToolStripButton tsbEditClientDetails;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip tsClientActions;
        private System.Windows.Forms.ToolStripButton tsbAddClient;
        private System.Windows.Forms.ToolStripButton tsbRemoveClient;
        private System.Windows.Forms.ListView lvClientsList;
        private System.Windows.Forms.ColumnHeader image;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
    }
}

