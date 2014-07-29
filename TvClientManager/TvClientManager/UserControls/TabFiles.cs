using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvClientManager.UserControls
{
    public partial class TabFiles : UserControl, ITab
    {
        public TabFiles()
        {
            InitializeComponent();
        }

        public TabState State { get; set; }
        public void OnLoad()
        {
            throw new NotImplementedException();
        }

        public void OnChange()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void SetReadOnly(bool isReadOnly)
        {
            throw new NotImplementedException();
        }
    }
}
