namespace TvClientManager
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbRecycle = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scClients = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewClient = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteClient = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.актToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvClientsList = new System.Windows.Forms.ListView();
            this.image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsClientActions = new System.Windows.Forms.ToolStrip();
            this.tsbAddClient = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveClient = new System.Windows.Forms.ToolStripButton();
            this.tsClientInfoActions = new System.Windows.Forms.ToolStrip();
            this.tbsSaveClientDetails = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelSaveClientDatails = new System.Windows.Forms.ToolStripButton();
            this.tsbEditClientDetails = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabBank = new System.Windows.Forms.TabPage();
            this.statusToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbStatus = new System.Windows.Forms.ToolStripButton();
            this.tslStatus = new System.Windows.Forms.ToolStripLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scClients)).BeginInit();
            this.scClients.Panel1.SuspendLayout();
            this.scClients.Panel2.SuspendLayout();
            this.scClients.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsClientActions.SuspendLayout();
            this.tsClientInfoActions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusToolStrip.SuspendLayout();
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
            this.scMain.SplitterDistance = 225;
            this.scMain.TabIndex = 4;
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
            this.scClients.Panel1.Controls.Add(this.toolStrip1);
            // 
            // scClients.Panel2
            // 
            this.scClients.Panel2.Controls.Add(this.lvClientsList);
            this.scClients.Size = new System.Drawing.Size(225, 413);
            this.scClients.SplitterDistance = 26;
            this.scClients.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewClient,
            this.tsbDeleteClient,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(225, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewClient
            // 
            this.tsbNewClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewClient.Image")));
            this.tsbNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewClient.Name = "tsbNewClient";
            this.tsbNewClient.Size = new System.Drawing.Size(23, 22);
            this.tsbNewClient.Text = "toolStripButton2";
            // 
            // tsbDeleteClient
            // 
            this.tsbDeleteClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteClient.Image")));
            this.tsbDeleteClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteClient.Name = "tsbDeleteClient";
            this.tsbDeleteClient.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteClient.Text = "toolStripButton2";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актToolStripMenuItem,
            this.договорToolStripMenuItem,
            this.счетToolStripMenuItem});
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(32, 22);
            this.tsbPrint.Text = "toolStripSplitButton1";
            // 
            // актToolStripMenuItem
            // 
            this.актToolStripMenuItem.Name = "актToolStripMenuItem";
            this.актToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.актToolStripMenuItem.Text = "Акт";
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.договорToolStripMenuItem.Text = "Договор";
            // 
            // счетToolStripMenuItem
            // 
            this.счетToolStripMenuItem.Name = "счетToolStripMenuItem";
            this.счетToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.счетToolStripMenuItem.Text = "Счет";
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
            this.lvClientsList.Size = new System.Drawing.Size(225, 383);
            this.lvClientsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvClientsList.TabIndex = 0;
            this.lvClientsList.UseCompatibleStateImageBehavior = false;
            this.lvClientsList.View = System.Windows.Forms.View.Details;
            // 
            // image
            // 
            this.image.Text = "";
            this.image.Width = 30;
            // 
            // Code
            // 
            this.Code.Text = "Код";
            this.Code.Width = 85;
            // 
            // Name
            // 
            this.Name.Text = "Название";
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
            this.splitContainer1.Panel1.Controls.Add(this.tsClientActions);
            this.splitContainer1.Panel1.Controls.Add(this.tsClientInfoActions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(693, 413);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // tsClientActions
            // 
            this.tsClientActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddClient,
            this.tsbRemoveClient});
            this.tsClientActions.Location = new System.Drawing.Point(0, 25);
            this.tsClientActions.Name = "tsClientActions";
            this.tsClientActions.Size = new System.Drawing.Size(693, 25);
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
            // tsClientInfoActions
            // 
            this.tsClientInfoActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsSaveClientDetails,
            this.tsbCancelSaveClientDatails,
            this.tsbEditClientDetails});
            this.tsClientInfoActions.Location = new System.Drawing.Point(0, 0);
            this.tsClientInfoActions.Name = "tsClientInfoActions";
            this.tsClientInfoActions.Size = new System.Drawing.Size(693, 25);
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
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabBank);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(685, 358);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Реквизиты";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabBank
            // 
            this.tabBank.Location = new System.Drawing.Point(4, 22);
            this.tabBank.Name = "tabBank";
            this.tabBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabBank.Size = new System.Drawing.Size(685, 358);
            this.tabBank.TabIndex = 1;
            this.tabBank.Text = "Банк";
            this.tabBank.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(685, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Каналы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(733, 358);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Услуги";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(733, 358);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Контактные лица";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(733, 358);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Оплата";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(733, 358);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Файлы";
            this.tabPage7.UseVisualStyleBackColor = true;
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
            this.scClients.Panel1.ResumeLayout(false);
            this.scClients.Panel1.PerformLayout();
            this.scClients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scClients)).EndInit();
            this.scClients.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsClientActions.ResumeLayout(false);
            this.tsClientActions.PerformLayout();
            this.tsClientInfoActions.ResumeLayout(false);
            this.tsClientInfoActions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusToolStrip.ResumeLayout(false);
            this.statusToolStrip.PerformLayout();
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
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabBank;
        private System.Windows.Forms.ToolStrip tsClientActions;
        private System.Windows.Forms.ToolStripButton tsbAddClient;
        private System.Windows.Forms.ToolStripButton tsbRemoveClient;
        private System.Windows.Forms.ListView lvClientsList;
        private System.Windows.Forms.ColumnHeader image;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewClient;
        private System.Windows.Forms.ToolStripButton tsbDeleteClient;
        private System.Windows.Forms.ToolStripSplitButton tsbPrint;
        private System.Windows.Forms.ToolStripMenuItem актToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
    }
}

