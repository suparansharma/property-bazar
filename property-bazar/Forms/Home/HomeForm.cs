using property_bazar.Froms.Client;
using property_bazar.Froms.Owner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace property_bazar.Forms.Main
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

      

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm c = new ClientForm();
            c.Show();
            this.Close();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            OwnerForm of = new OwnerForm();
            of.Show();
            this.Close();
        }
    }
}
