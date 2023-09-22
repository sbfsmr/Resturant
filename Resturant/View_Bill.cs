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
    public partial class View_Bill : Form
    {
        string SqlConString = "Server=LALALA;User Id=sa;Password=Sbf_786202110;Database=MicroProject";
        SqlConnection con; SqlCommand cmd; SqlDataAdapter Da;
        SqlDataReader Dr; SqlParameter P; DataSet Ds;
        DataRow DRow;
        SqlCommandBuilder Cb;
        
        int rows; string query;
        int sum = 0;
        public View_Bill()
        {
            InitializeComponent();
        }

        private void View_Bill_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlConString);
            cmd = new SqlCommand("Select BillNumber from BillMaster", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
                cmbBill.Items.Add(Dr[0]);
            con.Close();
        }

        private void cmbBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlConString);
            query = "Select * From BillMaster Where BillNumber='" + cmbBill.SelectedItem + "';Select * From BillTrans Where BillNumber='" + cmbBill.SelectedItem + "'";
            con.Open();
            Da = new SqlDataAdapter(query, con);
            Ds = new DataSet();
            Da.Fill(Ds, "Items");
            Da.FillSchema(Ds, SchemaType.Source, "Items");
            Cb = new SqlCommandBuilder(Da);
            BDGrid.DataSource = Ds.Tables[0];
            IDGrid.DataSource = Ds.Tables[1];
            con.Close();
        }
    }
}
