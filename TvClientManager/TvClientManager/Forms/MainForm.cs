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
using TvClientManager.Forms;

namespace TvClientManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            Login lg = new Login();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                lbProgramStatus.Text = "User " + lg.UserLogin + " login";
            }
            else
            {
                Close();
            }
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

        private void tsbClients_Click(object sender, EventArgs e)
        {
            AllExecutors ex = new AllExecutors();
            ex.ShowDialog();
        }

        private void tsbNewClient_Click(object sender, EventArgs e)
        {
            NewClient newCl = new NewClient();
            if (newCl.ShowDialog() == DialogResult.OK)
            {
                var client = newCl.CurrentClient;
            }
        }

        private void tsbChanels_Click(object sender, EventArgs e)
        {
            Chanels ch = new Chanels();
            ch.ShowDialog();
        }

        private void tsbCurrencies_Click(object sender, EventArgs e)
        {
            AllCurrency cur = new AllCurrency();
            cur.ShowDialog();
        }
    }
}
