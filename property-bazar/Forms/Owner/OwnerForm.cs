using property_bazar.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace property_bazar.Froms.Owner
{
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }



        public void AddOwner()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = string.Format("insert into tblUser (fname,lname)" +
            "values('{0}', '{1}')", txtOwnerFirstName.Text, txtOwnerLastName.Text);
            SqlCommand command = dataaccess.GetCommand(sql);



            command.Connection.Open();



            int rowsAffected = command.ExecuteNonQuery();



            if (rowsAffected > 0)
            {
                MessageBox.Show("Saved Successfully!!");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }



            command.Connection.Close();
        }



        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            AddOwner();
        }
    }
}

