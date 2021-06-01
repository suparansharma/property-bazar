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

        }

        private void textBoxClientPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
