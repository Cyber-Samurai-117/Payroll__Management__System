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

namespace GrifindoToysSystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7G9TL70\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True");
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "SELECT username, password FROM Login WHERE username='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {             

                this.Hide();
                MainMenu m = new MainMenu();
                m.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
