using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Data.SqlClient;

namespace FinalBrowser
{
    public partial class DateForm : MaterialForm
    {
        SqlConnection con = new SqlConnection();
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTRI611_DataWarehouse_2017DataSet.Date_Dim' table. You can move, or remove it, as needed.
            this.date_DimTableAdapter.Fill(this.iTRI611_DataWarehouse_2017DataSet.Date_Dim);

            con.ConnectionString = "data source = (local);database = ITRI611_DataWarehouse_2017;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select * from  Date_Dim", con);
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridViewDate.DataSource = source;

            con.Close();

        }
    }
}
