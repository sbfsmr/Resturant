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
    public partial class Bill_Trans : Form
    {
        SqlConnection con; SqlCommand cmd; SqlDataAdapter Da;
        SqlDataReader Dr; SqlParameter P; DataSet Ds;
        DataRow DRow;
        SqlCommandBuilder Cb;
        Bill_Master BM;
        int rows; string query;
        int sum = 0;
        
        public Bill_Trans()
        {
            InitializeComponent();
        }

        private void Bill_Trans_Load(object sender, EventArgs e)
        {
            string SqlConString = "Server=LALALA;User Id=sa;Password=Sbf_786202110;Database=MicroProject";
            con = new SqlConnection(SqlConString);
            cmd = new SqlCommand("Select Items from Items", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
                cmbItem.Items.Add(Dr[0]);
            con.Close();
            con.Open();
            GlobalData.Da = new SqlDataAdapter("Select * from BillTrans where BillNumber='"+GlobalData.BillNumber+"'", con);
            GlobalData.Ds = new DataSet();
            GlobalData.Da.Fill(GlobalData.Ds, "Bill_Trans");
            GlobalData.Da.FillSchema(GlobalData.Ds, SchemaType.Source, "Bill_Trans");
            GlobalData.Cb = new SqlCommandBuilder(GlobalData.Da);
            BillTransGrid.DataSource = GlobalData.Ds.Tables[0];
            con.Close();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select * From Items Where Items='" + cmbItem.SelectedItem + "'";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            Dr = cmd.ExecuteReader();
            Dr.Read();
            txtPrice.Text = Dr[1].ToString();
            con.Close();
            txtTotPrice.Text = txtPrice.Text;
        }

        private void tctQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tctQuant_TextChanged(object sender, EventArgs e)
        {
            double X;
            if (tctQuant.Text.Length > 0)
            {
                X = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(tctQuant.Text);
                txtTotPrice.Text = X.ToString();
            }
            else txtTotPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Ds.Tables[0].Columns.Contains(GlobalData.BillNumber))
            {
                DRow = GlobalData.Ds.Tables[0].NewRow();
                DRow[0] = GlobalData.BillNumber;
                DRow[1] = cmbItem.Text;
                DRow[2] = txtPrice.Text;
                if(tctQuant.Text.Length<=0)
                {
                    DRow[3] = "1";
                }
                else DRow[3] = tctQuant.Text;
                DRow[4] = txtTotPrice.Text;
                GlobalData.Ds.Tables[0].Rows.Add(DRow);
            }
            else
                MessageBox.Show("Item Already Exist");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    c.Text = "";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BillTransGrid.Rows.Count; i++)
            {
                sum += Convert.ToInt32(BillTransGrid.Rows[i].Cells[4].Value);
            }
            GlobalData.BTtotal = sum.ToString();
            //GlobalTable.GTable = Ds.Tables[0];
            this.Close();
           
        }
    }
}
