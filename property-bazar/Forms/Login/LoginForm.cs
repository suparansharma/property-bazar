using property_bazar.Database;
using property_bazar.Entities;
using property_bazar.Forms.Main;
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

namespace property_bazar.Forms.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = "select * " +
                " from [dbo].[tblLogin] where UserName='" + txtUserName.Text
                + "' and Password='" + txtPassword.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success!");
                Entities.Users user = new Users()
                {
                    Id = dt.Rows[0].Field<int>("Id"),//Int32.Parse(dt.Rows[0][0].ToString())
                    UserName = dt.Rows[0].Field<string>("UserName"), //dt.Rows[0][2].ToString(),
                    Password = dt.Rows[0][1].ToString(),

                    ///UpdatedTime = DateTime.Parse(dt.Rows[0][4].ToString()),
                    UserType = dt.Rows[0].Field<int>("UserType")
                };
                var userType = dt.Rows[0].Field<int>("UserType");

                if (userType == (int)Entities.Users.UserTypeEnum.Clients)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int ut = (int)Entities.Users.UserTypeEnum.Clients;
                    Users usr = new Users(id, txtUserName.Text, txtPassword.Text, ut);

                    MainForm m = new MainForm();
                    m.Show();


                    this.Hide();
                }
            }
        }
    }
}