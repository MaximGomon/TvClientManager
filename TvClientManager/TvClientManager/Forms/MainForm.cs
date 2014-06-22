using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            textBox1.Text = clientService.GetServerData(5);
            clientService.Close();
        }
    }
}
