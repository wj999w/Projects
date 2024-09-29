using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Text.RegularExpressions;



namespace Pet_Shelter_Management_System
{
    public partial class Login : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal string Sql { get; set; }
        internal DataSet Ds { get; set; }
        internal DataTable Dt { get; set; }




        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

       private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginPassword.Text) == true)
            {
                txtLoginPassword.Focus();
                errorProvider2.SetError(this.txtLoginPassword, "Please fill up password");



            }

            else
            {
                errorProvider2.Clear();
            }
        }
        private void txtLoginID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginID.Text) == true)
            {
                txtLoginID.Focus();
                errorProvider1.SetError(this.txtLoginID, "Invalid ID !!");
            }
            else
            {
                errorProvider1.Clear();
            }



        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                this.Sql = @"select *  from info
                      where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";

                this.Ds = this.Da.ExecuteQuery(this.Sql);
                string a = Ds.Tables[0].Rows[0][1].ToString();
                if (a == "user")
                {
                    MessageBox.Show("Login Successfull");

                    Dashboard user = new Dashboard();
                    this.Hide();
                    user.Show();
                }
                else if (a == "admin") 
                {
                    MessageBox.Show("Login Successfull");

                    AdminPanel admin = new AdminPanel();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid id or password");

                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error :" + exc.Message);
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLoginID.Text = "";
            this.txtLoginPassword.Text = "";
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}

 

         




