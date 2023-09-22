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
    public partial class New_User : Form
    {
        SqlConnection con; SqlCommand cmd;
        SqlDataReader Dr; SqlParameter P;
        int rows; string query;
        public New_User()
        {
            InitializeComponent();
        }


        private void New_User_Load(object sender, EventArgs e)
        {
            string constring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MyDb";
            con = new SqlConnection(constring);
            cmd = new SqlCommand("Select * from Hint_Questions", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
                cmbHintQues.Items.Add(Dr[0]);
            con.Close();
            constring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(constring);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            query = "Insert into Users values(@P1,@P2,@P3,@P4,@P5,@P6)";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@P1", UserName.Text);
            cmd.Parameters.AddWithValue("@P2", Password.Text);
            cmd.Parameters.AddWithValue("@P3", FName.Text);
            cmd.Parameters.AddWithValue("@P4", LName.Text);
            cmd.Parameters.AddWithValue("@P5", cmbHintQues.Text);
            cmd.Parameters.AddWithValue("@P6", HintAns.Text);
            if (UserName.Text.Length <= 0 ||Password.Text.Length <= 0 ||FName.Text.Length <= 0 ||LName.Text.Length <= 0 ||cmbHintQues.Text.Length <= 0 ||HintAns.Text.Length <= 0 )
            {
                MessageBox.Show("Enter Details");
                UserName.Focus();
                return;
            }
            else if (rePassword.Text.Length <= 0)
            {
                MessageBox.Show("Retype Password");
                rePassword.Focus();
                return;
            }
            con.Open();
            rows = cmd.ExecuteNonQuery();
            con.Close();
            if(rows>0)
                MessageBox.Show("Account Created");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                    c.ResetText();
            }
        }

        private void rePassword_Leave(object sender, EventArgs e)
        {
            if (Password.Text != rePassword.Text)
            {
                MessageBox.Show("Password Does not Match");
                rePassword.Focus();
            }
        }
        private void TxtValidation(object sender, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                    c.ResetText();
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
    }
}
