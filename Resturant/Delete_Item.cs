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
    public partial class Delete_Item : Form
    {
        SqlConnection con; SqlCommand cmd; SqlDataAdapter Da;
        DataRow Dr; SqlParameter P; DataSet Ds;
        SqlCommandBuilder Cb;
        int rows; string query,item,price;

        public Delete_Item()
        {
            InitializeComponent();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dr = Ds.Tables[0].Select("Items='" + ItemsGrid.SelectedCells[0].Value + "'")[0];
            Dr.Delete();
                        
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ds.HasChanges())
            {                
                rows=Da.Update(Ds, "Items");
                MessageBox.Show(rows + "Item(s) Updated to Database");
            }
            else
                MessageBox.Show("No Modification in Items Menu.");
        }

    }
}
