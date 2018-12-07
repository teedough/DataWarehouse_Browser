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
    public partial class Form1 : MaterialForm
    {
        SqlConnection con = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTRI611_DataWarehouse_2017DataSet.Shop_Dim' table. You can move, or remove it, as needed.
            this.shop_DimTableAdapter.Fill(this.iTRI611_DataWarehouse_2017DataSet.Shop_Dim);

        }

        private void FlatButtonStores_Click(object sender, EventArgs e)
        {
            panelStoreData.Visible = true;
            panelStoreData.BringToFront();

        }

        private void panelStoreData_Paint(object sender, PaintEventArgs e)
        {
          

            con.ConnectionString = "data source = (local);database = ITRI611_DataWarehouse_2017;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select shop_code,shop_name,shop_location from Shop_Dim " , con);
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridViewShops.DataSource = source;

            con.Close();
        }

        private void FlatButtonHome_Click(object sender, EventArgs e)
        {
            panelStoreData.Visible = false;
            panelHome.BringToFront();

            con.ConnectionString = "data source = (local);database = ITRI611_DataWarehouse_2017;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select TOP 100 * from Consumption_Fact ", con);
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridView1.DataSource = source;

            con.Close();
        }

        private void FlatButtonConsumption_Click(object sender, EventArgs e)
        {

            panelHome.Visible = true;
            panelHome.BringToFront();
            //panelStoreData.Visible = false;
            ConsumptionForm consForm = new ConsumptionForm();
            consForm.ShowDialog();

        }

        private void FlatButtonDates_Click(object sender, EventArgs e)
        {
            DateForm date = new DateForm();
            date.ShowDialog();

        }
    }
}
