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
    public partial class Employee : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-7G9TL70\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True");
        SqlCommand cmd;
        string gender,query;
        public Employee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter sd = new SqlDataAdapter("select isnull(max(cast(EID as int)),0)+1 from Employee", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            txteid.Text = dt.Rows[0][0].ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                query = "select * from Employee where EID='" + txteid.Text + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtfname.Text = dr["FirstName"].ToString();
                    txtlname.Text = dr["LastName"].ToString();
                    txtaddress.Text = dr["EAddress"].ToString();
                    if(dr["Gender"].ToString()=="Male")
                    {
                        rbmale.Checked=true;
                    }
                    else if(dr["Gender"].ToString()=="Female")
                    {
                        rbfemale.Checked=true;
                    }
                    if(dr["Gender"].ToString()=="Other")
                    {
                        rbother.Checked=true;
                    }
                    txtnic.Text=dr["NIC"].ToString();
                    dtdob.Text = dr["DOB"].ToString();
                    txtcontact.Text = dr["Contact"].ToString();
                    txtmsal.Text=dr["MonthlySalary"].ToString();
                    txtotrate.Text=dr["OTRate"].ToString();
                    txtallowance.Text=dr["Allowance"].ToString();
                
               }
               else
               {
                    MessageBox.Show("Employee not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               con.Close();
           }
           catch(Exception ex)
           {
                MessageBox.Show(ex.Message);
           }       
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (rbmale.Checked)
                {
                    gender = "Male";
                }
                else if (rbfemale.Checked)
                {
                    gender = "Female";
                }
                else if (rbother.Checked)
                {
                    gender = "Other";
                }
                
                con.Open();
                query = "insert into Employee (FirstName,LastName,EAddress,Gender,NIC,DOB,Contact,MonthlySalary,OTRate,Allowance,GovTax)values ('" + txtfname.Text + "','" + txtlname.Text + "','" + txtaddress.Text + "','" + gender + "','" + txtnic.Text + "','" + dtdob.Value + "','" + txtcontact.Text + "','" + txtmsal.Text + "','" + txtotrate.Text + "','" + txtallowance.Text + "','"+txtgovtax.Text+"')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved employee record", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*}
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbmale.Checked)
                {
                    gender = "Male";
                }
                else if (rbfemale.Checked)
                {
                    gender = "Female";
                }
                else if (rbother.Checked)
                {
                    gender = "Other";
                }
                
                con.Open();
                query = "update Employee set FirstName='" + txtfname.Text + "',LastName='" + txtlname.Text + "',EAddress='" + txtaddress.Text + "',Gender='" + gender + "',NIC='" + txtnic.Text + "',DOB='" + dtdob.Value + "',Contact='" + txtcontact.Text + "',MonthlySalary='" + txtmsal.Text + "',OTRate='" + txtotrate.Text + "' ,Allowance='" + txtallowance.Text + "'where EID='" + txteid.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete this employee record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.Open();
                    query = "delete from Employee where EID='" + txteid.Text + "'";     //Assigns the delete query to the variable
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Displays the success message
                    clear();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            txteid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtaddress.Clear();
            rbfemale.Checked = false;
            rbfemale.Checked = false;
            rbother.Checked = false;
            txtnic.Clear();
            dtdob.Value = DateTime.Today;
            txtcontact.Clear();
            txtmsal.Clear();
            txtotrate.Clear();
            txtallowance.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.grifindoDataSet.Employee);

        }

        private void btncaltax_Click(object sender, EventArgs e)
        {
            int tax;
            float sal=float.Parse(txtmsal.Text);
            if(sal>=200000)
            {
                tax = 3;
            }
            else if(sal>=100000)
            {
                tax = 2;
            }
            else if(sal>=75000)
            {
                tax = 1;
            }
            else
            {
                tax = 0;
            }
            txtgovtax.Text = tax.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
