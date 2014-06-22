using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvClientManager.ServiceReference;

namespace TvClientManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var clientService = ServiceManager.ServiceInstance;
            //textBox1.Text = clientService.GetServerData(5);
            clientService.Close();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeAllFormItems();
        }

        private void ResizeAllFormItems()
        {
            scMain.Height = this.Height - statusToolStrip.Height - tsMainMenu.Height;
        }

        private void tsbCalc_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }
    }
}
