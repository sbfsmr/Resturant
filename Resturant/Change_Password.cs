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
    public partial class Change_Password : Form
    {
        string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
        SqlConnection con; SqlCommand cmd; DataSet Ds;
        SqlDataReader Dr; SqlParameter P; SqlDataAdapter Da;SqlCommandBuilder Cb;
        int rows; string query;
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            optPass.Checked = true;
            string constring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MyDb";
            con = new SqlConnection(constring);
            cmd = new SqlCommand("Select * from Hint_Questions", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
                cmbQuest.Items.Add(Dr[0]);
            con.Close();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(Sqlconstring);
            cmd = new SqlCommand("OldPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            P = new SqlParameter("@P2UserName", SqlDbType.VarChar, 20);
            P.Value = GlobalData.UserName;
            cmd.Parameters.Add(P);
            P = new SqlParameter("@P1OldPassword", SqlDbType.VarChar, 20);
            P.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            string oldPass = cmd.Parameters["@P1OldPassword"].Value.ToString();
            if (oldPass == txtOldPass.Text)
            {
                //Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
                con = new SqlConnection(Sqlconstring);
                query = "Update Users set Password=@P1 where UserName='" + GlobalData.UserName+"'";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", txtNPass.Text);
                con.Open();
                rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                    MessageBox.Show("Password Updated");
            }
                else MessageBox.Show("Error");


        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            if(txtOldPass.Text.Length<=0)
            {
                MessageBox.Show("Enter Your old Password");
                txtOldPass.Focus();
            }
        }

        private void txtNPass_Leave(object sender, EventArgs e)
        {
            if (txtNPass.Text.Length <= 0)
            {
                MessageBox.Show("Enter Your New Password");
                txtNPass.Focus();
            }
        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if(txtNPass.Text!=txtRePass.Text)
            {
                MessageBox.Show("Password Does Not Match");
                txtRePass.Focus();
            }
        }
        private void optPass_CheckedChanged(object sender, EventArgs e)
        {
            if(optPass.Checked)
            {
                plnhint.Visible = false;
                plnPass.Visible = true;
            }
            else if(optHint.Checked)
            {
                plnPass.Visible = false;
                plnhint.Visible = true;
            }

        }

        private void optHint_CheckedChanged(object sender, EventArgs e)
        {
            if (optPass.Checked)
            {
                plnhint.Visible = false;
                plnPass.Visible = true;
            }
            else if (optHint.Checked)
            {
                plnPass.Visible = false;
                plnhint.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        private void btnHSubmit_Click(object sender, EventArgs e)
        {
            //string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(Sqlconstring);
            cmd = new SqlCommand("cngHintQues", con);
            cmd.CommandType = CommandType.StoredProcedure;
            P = new SqlParameter("@P3UserName", SqlDbType.VarChar, 20);
            P.Value = GlobalData.UserName;
            cmd.Parameters.Add(P);  
            P = new SqlParameter("@P1HintQuest", SqlDbType.VarChar, 50);
            P.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P);
            P = new SqlParameter("@P2HintAns", SqlDbType.VarChar, 50);
            P.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            string HintQuest = cmd.Parameters["@P1HintQuest"].Value.ToString();
            string HintAns = cmd.Parameters["@P2HintAns"].Value.ToString();
            //cmbQuest.Text = HintQuest;
            if(HintQuest==cmbQuest.Text && HintAns==txtHAns.Text)
            {
                con = new SqlConnection(Sqlconstring);
                query = "Update Users set Password=@P1 where UserName='" + GlobalData.UserName+"'";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", txtNHPass.Text);
                con.Open();
                rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                    MessageBox.Show("Password Updated");
                
            }
                else MessageBox.Show("Error");
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    c.Text = "";
            }
        }
    }
}
 