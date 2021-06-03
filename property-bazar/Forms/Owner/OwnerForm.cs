using property_bazar.Database;
using property_bazar.Froms.Client;
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
            string sql = string.Format("insert into tblOwner (ownerFirstName, ownerLastName, ownerUserName, ownerEmail, ownerPhoneNumber, ownerAddress, updatedTime)" +
            "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' )", txtOwnerFirstName.Text, txtOwnerLastName.Text, txtOwnerUserName.Text, txtOwnerEmail.Text, txtOwnerPhoneNumber.Text, txtOwnerAddress.Text, System.DateTime.Now.ToString());
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
            ClientForm c = new ClientForm();
            c.Show();
        }
        DataTable dt;
        private void btnViewOwner_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblClient ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewOwner.DataSource = dt;

        }
    }
}

