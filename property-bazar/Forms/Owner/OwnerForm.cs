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
        DataAccess dataAccess = new DataAccess();
        public OwnerForm()
        {
            InitializeComponent();
        }


        
        public void AddOwner()
        {
            string sql = string.Format("insert into tblOwner (ownerFirstName, ownerLastName, ownerUserName, ownerEmail, ownerPhoneNumber, ownerAddress, updatedTime)" +
            "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' )", txtOwnerFirstName.Text, txtOwnerLastName.Text, txtOwnerUserName.Text, txtOwnerEmail.Text, txtOwnerPhoneNumber.Text, txtOwnerAddress.Text, System.DateTime.Now.ToString());
            SqlCommand command = dataAccess.GetCommand(sql);

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
            String query = "Select * FROM tblOwner ";
            SqlCommand commandd = dataAccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewOwner.DataSource = dt;

        }

        private void dataGridViewOwner_DoubleClick(object sender, EventArgs e)
        {
            txtOwnerFirstName.Text = dataGridViewOwner.SelectedRows[0].Cells[0].Value.ToString();
            txtOwnerLastName.Text = dataGridViewOwner.SelectedRows[0].Cells[1].Value.ToString();
            txtOwnerUserName.Text = dataGridViewOwner.SelectedRows[0].Cells[2].Value.ToString();
            txtOwnerEmail.Text = dataGridViewOwner.SelectedRows[0].Cells[3].Value.ToString();
            txtOwnerPhoneNumber.Text = dataGridViewOwner.SelectedRows[0].Cells[4].Value.ToString();
            txtOwnerAddress.Text = dataGridViewOwner.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnOwnerUpdate_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Select * FROM tblOwner  ");
            SqlCommand commandd = dataAccess.GetCommand(sql1);
            commandd.Connection.Open();
            string query = " UPDATE tblOwner SET ownerFirstName = '" + txtOwnerFirstName.Text + "', ownerLastName = '" + txtOwnerLastName.Text + "', ownerEmail= '" + txtOwnerEmail.Text + "', ownerPhoneNumber= '" + txtOwnerPhoneNumber.Text + "', ownerAddress= '" + txtOwnerAddress.Text + " ' WHERE ownerUserName = '" + txtOwnerUserName.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated");

            commandd.Connection.Close();

        }

        private void btnOwnerDelete_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Select * FROM tblemployeeGenarelInfo ");
            SqlCommand commandd = dataAccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblOwner  WHERE ownerUserName ='" + txtOwnerUserName.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
            MessageBox.Show("Delete successfully!!!!");
        }
    }
}
