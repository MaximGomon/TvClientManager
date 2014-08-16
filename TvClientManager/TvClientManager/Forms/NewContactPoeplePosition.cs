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
    public partial class NewContactPoeplePosition : Form
    {
        public NewContactPoeplePosition()
        {
            InitializeComponent();
        }

        public ContactPeoplePosition CurrentPosition { get; set; }

        private void btSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
