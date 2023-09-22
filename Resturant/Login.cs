using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resturant
{
    public partial class Login : Form
    {
        SqlConnection con; SqlCommand cmd; SqlDataReader Dr;
        SqlParameter P;string query; int rows;
        Resturant Obj1;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string constring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(constring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Enter Details");
                txtUserName.Focus();
                return;
            }
            cmd = new SqlCommand("Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            P = new SqlParameter("@P1UserName", SqlDbType.VarChar, 20);
            P.Value = txtUserName.Text;
            cmd.Parameters.Add(P);
            P = new SqlParameter("@P2Password", SqlDbType.VarChar, 20);
            P.Value = txtPassword.Text;
            cmd.Parameters.Add(P);
            con.Open();
            Dr = cmd.ExecuteReader();
            if (Dr.Read())
            {
                GlobalData.UserName = txtUserName.Text;
                GlobalData.Password = txtPassword.Text;
                MessageBox.Show("Login Successfull");
                Obj1 = new Resturant();
                this.Hide();
                Obj1.ShowDialog();
                this.Close();
                con.Close();
            }
            
            else MessageBox.Show("Username / Password Incorrect");
            con.Close();

        }

    }
}
