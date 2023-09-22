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
    public partial class View_Users : Form
    {
        SqlConnection con;
        SqlCommand cmd; SqlDataAdapter Da;
        DataRow Dr;
        DataSet Ds;
        SqlCommandBuilder Cb;
        SqlParameter P;
        DataGridViewRow Dv;
        int rows;
        public View_Users()
        {
            InitializeComponent();
        }

        private void View_Users_Load(object sender, EventArgs e)
        {
            string Sqlconstring = "Server=LALALA; User Id=sa; Password=Sbf_786202110; Database=MicroProject";
            con = new SqlConnection(Sqlconstring);
            con.Open();
            Da = new SqlDataAdapter("Select UserName, FirstName, LastName from Users", con);
            Ds = new DataSet();
            Da.Fill(Ds, "Items");
            Da.FillSchema(Ds, SchemaType.Source, "Items");
            Cb = new SqlCommandBuilder(Da);
            UserGrid.DataSource = Ds.Tables[0];
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
