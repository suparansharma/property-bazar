using property_bazar.Database;
using property_bazar.RandomNumberSample;
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

namespace property_bazar.Froms.Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void textBoxOwnerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClientEmail_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddClient()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = string.Format("insert into tblClient (firstName,lastName,email,phoneNumber,address)" +
            "values('{0}', '{1}','{2}','{3}','{4}')", txtClientFirstName.Text, txtClientLastName.Text, txtClientEmail.Text, txtClientPhoneNumber.Text, txtClientAddress.Text);
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



        public void loginTableInsert()
        {

            DataAccess dataaccess = new DataAccess();
            RandomGenerator generator = new RandomGenerator();
            string pass = generator.RandomPassword();
            txtClientPassword.Text = pass;
            string sql1 = string.Format("insert into tblLogin (userName,password,updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}','{3}')", txtClientUserName.Text, pass, System.DateTime.Now.ToString(), 2);
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Insert Successfully!!" + " Password is " + pass);

            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient();
        }
        DataTable dt;

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblClient ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBoxClientId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtClientFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtClientLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtClientEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtClientPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtClientAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            
          

        }

        private void textBoxClientPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblClient  ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            
            String query = "UPDATE tblClient SET firstName= '" + txtClientFirstName.Text + "',lastName= '" + txtClientLastName.Text + "',email= '" + txtClientEmail.Text + "',phoneNumber= '" + txtClientPhoneNumber.Text + "',address= '" + txtClientAddress.Text + "' WHERE Id ='" + textBoxClientId.Text + "' "; 

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated");

            commandd.Connection.Close();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblClient ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblClient  WHERE Id ='" + textBoxClientId.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
            MessageBox.Show("Delete successfully!!!!");
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
