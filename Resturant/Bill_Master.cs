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
    public partial class Bill_Master : Form
    {
        string constring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
        SqlConnection con; SqlCommand cmd; DataSet Ds;
        SqlDataReader Dr; SqlParameter P; SqlDataAdapter Da; SqlCommandBuilder Cb;
        int rows,BVal; string query;Bill_Trans BT;string Invo; double A,B,C,R,X,Y,Z;

        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalData.BTtotal = "";
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Bill_Master_Load(sender, e);
            txtBillAmt.Clear();
            txtDIsco.Clear();
            txtTotal.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                query = "Insert into BillMaster values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", txtBillNum.Text);
                cmd.Parameters.AddWithValue("@P2", txtBillDate.Text);
                cmd.Parameters.AddWithValue("@P3", txtBillAmt.Text);
                cmd.Parameters.AddWithValue("@P4", txtCGST.Text);
                cmd.Parameters.AddWithValue("@P5", txtSGST.Text);
                cmd.Parameters.AddWithValue("@P6", txtDIsco.Text);
                cmd.Parameters.AddWithValue("@P7", txtTotal.Text);
                cmd.Parameters.AddWithValue("@P8", GlobalData.UserName);
                con.Open();
                rows = cmd.ExecuteNonQuery();
                con.Close();
            }
            else MessageBox.Show("Error");

            if (GlobalData.Ds.HasChanges())
            {
                rows = GlobalData.Da.Update(GlobalData.Ds, "Bill_Trans");
                MessageBox.Show(rows + "Item(s) Updated to Database");
            }
            else
                MessageBox.Show("No Modification in Items Menu.");
            this.btnClear_Click(sender, e);
        }

        private void txtDIsco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Bill_Master()
        {
            InitializeComponent();
        }

        private void btnAdItem_Click(object sender, EventArgs e)
        { 
            BT = new Bill_Trans();
            BT.IsMdiContainer = true;
            BT.ShowDialog();
            txtBillAmt.Text = GlobalData.BTtotal;
        }

        private void txtDIsco_TextChanged(object sender, EventArgs e)
        {
            if(txtBillAmt.Text.Length>0)
                A = Convert.ToDouble(txtBillAmt.Text);
            B = Convert.ToDouble(txtCGST.Text);
            C = Convert.ToDouble(txtSGST.Text);
            
            X = (A * (B / 100));
            Y = (A * (C / 100));
            Z = A + X + Y;
            if (txtDIsco.Text.Length > 0)
            {
                R = Z - (Z * (Convert.ToDouble(txtDIsco.Text)) / 100);
                txtTotal.Text = R.ToString();
            }
            else txtTotal.Text=Z.ToString();
        }

        private void Bill_Master_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            cmd = new SqlCommand("Select max(BillNumber) from BillMaster", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            string BNum = cmd.ExecuteScalar().ToString();
            if(BNum=="")
            {
                Invo= "B-00001";
                txtBillNum.Text = Invo;
                GlobalData.BillNumber = Invo;
            }
            else
            {
                BVal = Convert.ToInt32(BNum.Substring(2,5));
                BVal++;
                Invo= string.Format("B-{0:00000}", BVal);
                GlobalData.BillNumber = Invo;
                txtBillNum.Text = Invo;
            }
            con.Close();
            txtBillDate.Text = DateTime.Now.ToString();            
                cmd = new SqlCommand("PTax", con);
                cmd.CommandType = CommandType.StoredProcedure;
                P = new SqlParameter("@P2SGST", SqlDbType.VarChar, 20);
                P.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P);
                P = new SqlParameter("@P1CGST", SqlDbType.VarChar, 20);
                P.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtCGST.Text = cmd.Parameters["@P1CGST"].Value.ToString();
                txtSGST.Text = cmd.Parameters["@P2SGST"].Value.ToString();
            if (GlobalData.BTtotal == "")
            {
                txtBillAmt.Text = "0";
            }
            else txtBillAmt.Text = GlobalData.BTtotal;
            
            if (txtDIsco.Text.Length > 0)
                if (txtDIsco.Text.Length <= 0)
                txtTotal.Text = Z.ToString();
        }
    }
}
