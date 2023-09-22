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
    public partial class Delete_User : Form
    {
        SqlConnection con; 
        SqlCommand cmd; SqlDataAdapter Da;
        DataRow Dr; 
        DataSet Ds; 
        SqlCommandBuilder Cb;
        SqlParameter P;
        DataGridViewRow Dv;
        int rows; string query;

        

        public Delete_User()
        {
            InitializeComponent();
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {
            string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(Sqlconstring);
            con.Open();
            query = "Select UserName, FirstName, LastName from Users except select UserName, FirstName,LastName from Users Where UserName='" + GlobalData.UserName + "'";
            Da = new SqlDataAdapter(query, con);
            Ds = new DataSet();
            Da.Fill(Ds, "Items");
            Da.FillSchema(Ds, SchemaType.Source, "Items");
            Cb = new SqlCommandBuilder(Da);
            UserGrid.DataSource = Ds.Tables[0];
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           Dr = Ds.Tables[0].Select("UserName='" + UserGrid.SelectedCells[0].Value + "'")[0];
           Dr.Delete();
           if (Ds.HasChanges())
           {
                rows = Da.Update(Ds, "Items");
                MessageBox.Show(rows + "User(s) Deleted from Database");
           }
           else
              MessageBox.Show("No Modification Done");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
