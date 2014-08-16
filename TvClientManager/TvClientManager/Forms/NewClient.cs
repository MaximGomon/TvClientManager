using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalEntity;

namespace TvClientManager.Forms
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        public TvClients CurrentClient
        {
            get
            {
                TvClients cl = new TvClients();

                cl.BlockedDate = null;
                //cl.ClientState = ClientState.
                cl.Code = tbClientCode.Text;
                //cl.Comment = tb
                cl.CreateDate = DateTime.Now;
                
                var cur = (Currencies) cbCurrency.SelectedItem;
                var exec = (Executors) cbExecutor.SelectedItem;
                var lang = (Languages) cbExecutor.SelectedItem;

                cl.CurrencyId = cur.Id;
                cl.Email = tbEmail.Text;
                cl.ExecutorId = exec.Id;
                cl.LanguageId = lang.Id;
                cl.Telephone = tbTelephone.Text;
                cl.Name = tbClientName.Text;
                //cl.Fax = 
                cl.PayRate = Convert.ToDouble(tbPrice.Text);
                cl.RegisterDate = dtpRegistrationDate.Value;
                //cl.

                return cl;
            }
            //set;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAddExecutor_Click(object sender, EventArgs e)
        {
            NewExecutor newExecutor = new NewExecutor();
            if (newExecutor.ShowDialog() == DialogResult.OK)
            {
                //var exec = newExecutor.CurrentExecutor;
                FillExecutorsComboBox();
            }
        }

        private void FillExecutorsComboBox()
        {
            //var exec = ServiceManager.ServiceInstance.
        }

        private void btAddCurrency_Click(object sender, EventArgs e)
        {
            NewCurrency newCur = new NewCurrency();
            if (newCur.ShowDialog() == DialogResult.OK)
            {
                var cur = newCur.CurrentCurrencies;
            }
        }

        private void btAddLang_Click(object sender, EventArgs e)
        {
            NewLanguage newLanguage = new NewLanguage();
            if (newLanguage.ShowDialog() == DialogResult.OK)
            {
                var lang = newLanguage.CurrentLanguages;
            }
        }
    }
}
