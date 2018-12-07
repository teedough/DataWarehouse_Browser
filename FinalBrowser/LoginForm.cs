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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TextFieldPass_Click(object sender, EventArgs e)
        {

        }

        private void FlatButtonSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source = (local);database = ITRI611_DataWarehouse_2017;integrated security = SSPI"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + TextFieldUser.Text + "' AND password='" + TextFieldPass.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                this.Hide();
                new Form1().Show();
            }
            else
                
                MessageBox.Show("Invalid username or password");  
        }


    }
}
