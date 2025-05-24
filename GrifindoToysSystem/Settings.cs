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
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7G9TL70\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True");
        SqlCommand cmd;
        string query;
        public Settings()
        {
            InitializeComponent();
        }

        private void dtcycleend_ValueChanged(object sender, EventArgs e)
        {
            DateTime stdate, enddate;
            TimeSpan gap;
            int daterange;
            stdate = DateTime.Parse(dtcyclestartdate.Text);
            enddate = DateTime.Parse(dtcycleend.Text);
            gap = enddate - stdate;
            daterange = gap.Days;
            txtdaterange.Text = daterange.ToString();
            
        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                query = "insert into Settings (SalCycleStartDate,SalCycleEndDate,DateRange,NoLeaves)values ('" + dtcyclestartdate.Value + "','" + dtcycleend.Value + "','" + txtdaterange.Text + "','" + nudleavesperyear.Value + "')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Settings Updated Successfully!!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void nudleavesperyear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
