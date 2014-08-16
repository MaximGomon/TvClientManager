using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvClientManager.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string UserLogin
        {
            get
            {
                return tbUserLogin.Text.Trim();
            }
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            var clientService = ServiceManager.ServiceInstance;
            if (clientService.ClientLogin(UserLogin, tbUserPassword.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }

            clientService.Close();

            this.Close();
            //if(clientService.)
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
