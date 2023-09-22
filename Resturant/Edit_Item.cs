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
    public partial class Edit_Item : Form
    {
        SqlConnection con; SqlDataAdapter Da;
        DataRow Dr; DataSet Ds;
        SqlCommandBuilder Cb;
        int rows;
        public Edit_Item()
        {
            InitializeComponent();
        }

        private void Edit_Item_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ds.HasChanges())
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
            foreach (Control c in this.Controls)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtItem.Text.Length <= 0 || txtPrice.Text.Length <= 0)
            {
                MessageBox.Show("Item / Price Can not be empty");
                txtItem.Focus();
                return;
            }
            else if (Ds.Tables[0].Rows.Contains(txtItem.Text))
            {
                //rows = ItemsGrid.SelectedRows[0].Index;
                Dr = Ds.Tables[0].Select("Items='" + ItemsGrid.SelectedCells[0].Value + "'")[0];
                //Dr[0] = txtItem.Text;
                Dr[1] = txtPrice.Text;
                
            }
            else
                MessageBox.Show("Item Already Exist");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }


        }

        private void ItemsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtItem.Text = ItemsGrid.SelectedCells[0].Value.ToString();
            txtPrice.Text = ItemsGrid.SelectedCells[1].Value.ToString();
        }
    }
}
