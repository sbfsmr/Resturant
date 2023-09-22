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
    public partial class Add_Item : Form
    {
        SqlConnection con; SqlCommand cmd; SqlDataAdapter Da;
        DataRow Dr; SqlParameter P; DataSet Ds;
        SqlCommandBuilder Cb;
        int rows; string query;
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(Sqlconstring);
            con.Open();
            Da = new SqlDataAdapter("Select * from items", con);     
            Ds = new DataSet();
            Da.Fill(Ds, "Items");
            Da.FillSchema(Ds, SchemaType.Source, "Items");
            Cb = new SqlCommandBuilder(Da);
            ItemsGrid.DataSource = Ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItem.Text.Length<=0 || txtPrice.Text.Length<=0)
            {
                MessageBox.Show("Item / Price Can not be empty");
                txtItem.Focus();
                return;
            }
            else if (!Ds.Tables[0].Rows.Contains(txtItem.Text))
            {
                Dr = Ds.Tables[0].NewRow();
                Dr[0] = txtItem.Text;
                Dr[1] = txtPrice.Text;
                Ds.Tables[0].Rows.Add(Dr);
            }
            else
                MessageBox.Show("Item Already Exist");
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Ds.HasChanges())
            {
                rows = Da.Update(Ds.Tables[0]);
                MessageBox.Show(rows + "Item(s) Updated to Database");
            }
            else
                MessageBox.Show("No Modification in Items Menu.");
        }   

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
           
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {

            }
            else if (e.KeyChar < 65 || e.KeyChar > 91 && e.KeyChar < 97 || e.KeyChar > 123)
            {
                e.Handled = true;
            }
            
            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Add_Item_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Add_Item_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
