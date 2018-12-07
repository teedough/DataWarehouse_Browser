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
    public partial class ConsumptionForm : MaterialForm
    {
        SqlConnection con = new SqlConnection();
        public ConsumptionForm()
        {
            InitializeComponent();
        }

        private void ConsumptionForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "data source = (local);database = ITRI611_DataWarehouse_2017;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select consumption_type from  Cons_Type_Dim", con);
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridViewCon.DataSource = source;

            con.Close();
        }
    }
}
