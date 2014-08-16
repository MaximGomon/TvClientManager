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
    public partial class NewContactPeople : Form
    {
        public NewContactPeople()
        {
            InitializeComponent();
            FillPositionsCb();
        }

        private void FillPositionsCb()
        {
            cbPosition.Items.Clear();

            List<Positions> allPositions = new List<Positions>();

            cbPosition.DataSource = allPositions;// DataBindings.Add("")
            cbPosition.DisplayMember = "Title";
        }

        public ContactPeople CurrentPeople
        {
            get
            {
                Positions posId = (Positions)cbPosition.SelectedItem;

                ContactPeople cp = new ContactPeople();
                cp.Email = tbEmail.Text;
                cp.Name = tbFullName.Text;
                cp.Telephone = tbTelephone.Text;
                cp.PositionId = posId.Id;
                cp.IsDelete = 0;
                cp.CreateDate = DateTime.Now;
                
                return cp;
            }
            //set;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            var newCpPosition = new NewContactPoeplePosition();
            if (newCpPosition.ShowDialog() == DialogResult.OK)
            {
                FillPositionsCb();
            }
        }
    }
}
