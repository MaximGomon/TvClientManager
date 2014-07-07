namespace TvClientManager.Forms
{
    partial class Executors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Executors));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lvExecutors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsExecutorsActivity = new System.Windows.Forms.ToolStrip();
            this.tsbNewExecutor = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteExecutor = new System.Windows.Forms.ToolStripButton();
            this.tsbEditExecutor = new System.Windows.Forms.ToolStripButton();
            this.tsOkCancel = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpIndDerghNumDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndDerghNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelephon = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFAdress = new System.Windows.Forms.TextBox();
            this.lblFAdress = new System.Windows.Forms.Label();
            this.txtPAdress = new System.Windows.Forms.TextBox();
            this.lblPAdress = new System.Windows.Forms.Label();
            this.txtUrAdress = new System.Windows.Forms.TextBox();
            this.lblUrAdress = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tsExecutorsActivity.SuspendLayout();
            this.tsOkCancel.SuspendLayout();
            this.gbComments.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.lvExecutors);
            this.mainSplitContainer.Panel1.Controls.Add(this.tsExecutorsActivity);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tsOkCancel);
            this.mainSplitContainer.Panel2.Controls.Add(this.gbComments);
            this.mainSplitContainer.Panel2.Controls.Add(this.gbMain);
            this.mainSplitContainer.Size = new System.Drawing.Size(926, 576);
            this.mainSplitContainer.SplitterDistance = 242;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // lvExecutors
            // 
            this.lvExecutors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvExecutors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExecutors.GridLines = true;
            this.lvExecutors.Location = new System.Drawing.Point(0, 25);
            this.lvExecutors.Name = "lvExecutors";
            this.lvExecutors.Size = new System.Drawing.Size(242, 551);
            this.lvExecutors.TabIndex = 1;
            this.lvExecutors.UseCompatibleStateImageBehavior = false;
            this.lvExecutors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 232;
            // 
            // tsExecutorsActivity
            // 
            this.tsExecutorsActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewExecutor,
            this.tsbDeleteExecutor,
            this.tsbEditExecutor});
            this.tsExecutorsActivity.Location = new System.Drawing.Point(0, 0);
            this.tsExecutorsActivity.Name = "tsExecutorsActivity";
            this.tsExecutorsActivity.Size = new System.Drawing.Size(242, 25);
            this.tsExecutorsActivity.TabIndex = 0;
            this.tsExecutorsActivity.Text = "toolStrip1";
            // 
            // tsbNewExecutor
            // 
            this.tsbNewExecutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewExecutor.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewExecutor.Image")));
            this.tsbNewExecutor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewExecutor.Name = "tsbNewExecutor";
            this.tsbNewExecutor.Size = new System.Drawing.Size(23, 22);
            this.tsbNewExecutor.Text = "toolStripButton1";
            // 
            // tsbDeleteExecutor
            // 
            this.tsbDeleteExecutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteExecutor.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteExecutor.Image")));
            this.tsbDeleteExecutor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteExecutor.Name = "tsbDeleteExecutor";
            this.tsbDeleteExecutor.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteExecutor.Text = "toolStripButton1";
            // 
            // tsbEditExecutor
            // 
            this.tsbEditExecutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditExecutor.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditExecutor.Image")));
            this.tsbEditExecutor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditExecutor.Name = "tsbEditExecutor";
            this.tsbEditExecutor.Size = new System.Drawing.Size(23, 22);
            this.tsbEditExecutor.Text = "toolStripButton1";
            // 
            // tsOkCancel
            // 
            this.tsOkCancel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbCancel});
            this.tsOkCancel.Location = new System.Drawing.Point(0, 0);
            this.tsOkCancel.Name = "tsOkCancel";
            this.tsOkCancel.Size = new System.Drawing.Size(680, 25);
            this.tsOkCancel.TabIndex = 3;
            this.tsOkCancel.Text = "toolStrip2";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "toolStripButton1";
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(23, 22);
            this.tsbCancel.Text = "toolStripButton1";
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.textBox2);
            this.gbComments.Location = new System.Drawing.Point(10, 365);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(658, 206);
            this.gbComments.TabIndex = 2;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Коментарии";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(627, 169);
            this.textBox2.TabIndex = 4;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.textBox1);
            this.gbMain.Controls.Add(this.dtpIndDerghNumDate);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.txtIndDerghNumber);
            this.gbMain.Controls.Add(this.lblEmail);
            this.gbMain.Controls.Add(this.txtEmail);
            this.gbMain.Controls.Add(this.lblTelephon);
            this.gbMain.Controls.Add(this.txtName);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.txtFullName);
            this.gbMain.Controls.Add(this.lblFullName);
            this.gbMain.Controls.Add(this.txtFAdress);
            this.gbMain.Controls.Add(this.lblFAdress);
            this.gbMain.Controls.Add(this.txtPAdress);
            this.gbMain.Controls.Add(this.lblPAdress);
            this.gbMain.Controls.Add(this.txtUrAdress);
            this.gbMain.Controls.Add(this.lblUrAdress);
            this.gbMain.Location = new System.Drawing.Point(10, 34);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(659, 325);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Общее";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(430, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 28;
            // 
            // dtpIndDerghNumDate
            // 
            this.dtpIndDerghNumDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIndDerghNumDate.Location = new System.Drawing.Point(552, 223);
            this.dtpIndDerghNumDate.Name = "dtpIndDerghNumDate";
            this.dtpIndDerghNumDate.Size = new System.Drawing.Size(91, 20);
            this.dtpIndDerghNumDate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "от ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Свидетельство про дер. реестрацию №:";
            // 
            // txtIndDerghNumber
            // 
            this.txtIndDerghNumber.Location = new System.Drawing.Point(339, 223);
            this.txtIndDerghNumber.Name = "txtIndDerghNumber";
            this.txtIndDerghNumber.Size = new System.Drawing.Size(188, 20);
            this.txtIndDerghNumber.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(336, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(430, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblTelephon
            // 
            this.lblTelephon.AutoSize = true;
            this.lblTelephon.Location = new System.Drawing.Point(336, 169);
            this.lblTelephon.Name = "lblTelephon";
            this.lblTelephon.Size = new System.Drawing.Size(55, 13);
            this.lblTelephon.TabIndex = 20;
            this.lblTelephon.Text = "Телефон:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Имя:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(107, 49);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(213, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(13, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 13);
            this.lblFullName.TabIndex = 18;
            this.lblFullName.Text = "Директор:";
            // 
            // txtFAdress
            // 
            this.txtFAdress.Location = new System.Drawing.Point(339, 40);
            this.txtFAdress.Multiline = true;
            this.txtFAdress.Name = "txtFAdress";
            this.txtFAdress.Size = new System.Drawing.Size(304, 88);
            this.txtFAdress.TabIndex = 4;
            // 
            // lblFAdress
            // 
            this.lblFAdress.AutoSize = true;
            this.lblFAdress.Location = new System.Drawing.Point(336, 21);
            this.lblFAdress.Name = "lblFAdress";
            this.lblFAdress.Size = new System.Drawing.Size(112, 13);
            this.lblFAdress.TabIndex = 16;
            this.lblFAdress.Text = "Фактический адрес:";
            // 
            // txtPAdress
            // 
            this.txtPAdress.Location = new System.Drawing.Point(16, 223);
            this.txtPAdress.Multiline = true;
            this.txtPAdress.Name = "txtPAdress";
            this.txtPAdress.Size = new System.Drawing.Size(304, 88);
            this.txtPAdress.TabIndex = 3;
            // 
            // lblPAdress
            // 
            this.lblPAdress.AutoSize = true;
            this.lblPAdress.Location = new System.Drawing.Point(13, 204);
            this.lblPAdress.Name = "lblPAdress";
            this.lblPAdress.Size = new System.Drawing.Size(93, 13);
            this.lblPAdress.TabIndex = 14;
            this.lblPAdress.Text = "Почтовый адрес:";
            // 
            // txtUrAdress
            // 
            this.txtUrAdress.Location = new System.Drawing.Point(16, 103);
            this.txtUrAdress.Multiline = true;
            this.txtUrAdress.Name = "txtUrAdress";
            this.txtUrAdress.Size = new System.Drawing.Size(304, 88);
            this.txtUrAdress.TabIndex = 2;
            // 
            // lblUrAdress
            // 
            this.lblUrAdress.AutoSize = true;
            this.lblUrAdress.Location = new System.Drawing.Point(13, 84);
            this.lblUrAdress.Name = "lblUrAdress";
            this.lblUrAdress.Size = new System.Drawing.Size(111, 13);
            this.lblUrAdress.TabIndex = 12;
            this.lblUrAdress.Text = "Юридический адрес:";
            // 
            // Executors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 576);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Executors";
            this.Text = "Исполнители";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tsExecutorsActivity.ResumeLayout(false);
            this.tsExecutorsActivity.PerformLayout();
            this.tsOkCancel.ResumeLayout(false);
            this.tsOkCancel.PerformLayout();
            this.gbComments.ResumeLayout(false);
            this.gbComments.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView lvExecutors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStrip tsExecutorsActivity;
        private System.Windows.Forms.ToolStripButton tsbNewExecutor;
        private System.Windows.Forms.ToolStripButton tsbDeleteExecutor;
        private System.Windows.Forms.ToolStripButton tsbEditExecutor;
        private System.Windows.Forms.ToolStrip tsOkCancel;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpIndDerghNumDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndDerghNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelephon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFAdress;
        private System.Windows.Forms.Label lblFAdress;
        private System.Windows.Forms.TextBox txtPAdress;
        private System.Windows.Forms.Label lblPAdress;
        private System.Windows.Forms.TextBox txtUrAdress;
        private System.Windows.Forms.Label lblUrAdress;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}