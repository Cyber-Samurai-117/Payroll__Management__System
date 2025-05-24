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
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7G9TL70\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True");
        SqlCommand cmd;
        string query;
        float tax;
         

        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            //Display the next SalaryID in the textbox at runtime
           /* SqlDataAdapter salid = new SqlDataAdapter("select isnull(max(cast(SalID as int)),0)+1 from Salary", con);
            DataTable dt1 = new DataTable();
            salid.Fill(dt1);
            txtsalid.Text = dt1.Rows[0][0].ToString();*/

            //Display the next PayRollID in the textbox at runtime
            SqlDataAdapter prid  = new SqlDataAdapter("select isnull(max(cast(PRID as int)),0)+1 from PayRoll", con);
            DataTable dt2 = new DataTable();
            prid.Fill(dt2);
            txtpayrollid.Text = dt2.Rows[0][0].ToString();
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
                    txtlastname.Text = dr["LastName"].ToString();
                    if (dr["Gender"].ToString() == "Male")
                    {
                        rbmale.Checked = true;
                    }
                    else if (dr["Gender"].ToString() == "Female")
                    {
                        rbfemale.Checked = true;
                    }
                    if (dr["Gender"].ToString() == "Other")
                    {
                        rbother.Checked = true;
                    }
                    txtnic.Text = dr["NIC"].ToString();                  
                    txtmsal.Text = dr["MonthlySalary"].ToString();
                    txtotrate.Text = dr["OTRate"].ToString();
                    txtallowance.Text = dr["Allowance"].ToString();
                    txtgovtax.Text = dr["GovTax"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            //Variable declaration
            float overtime,nopay,monthlysal,overallattendance, cycledaterange, absentdays,basepay,allowance,otrate,othrs,grosspay,taxrate;
            
            overallattendance = float.Parse(txtattendance.Text);
            cycledaterange = float.Parse(txtcycledaterange.Text);
            absentdays = float.Parse(txtabsentdays.Text);
            monthlysal = float.Parse(txtmsal.Text);

            //NOPAY CALCULATION 
            if (overallattendance < cycledaterange)
            {
                nopay = (monthlysal / cycledaterange) * absentdays;
                txtnopay.Text = nopay.ToString();
            }
            
            //BASE PAY CALCULATION
            allowance = float.Parse(txtallowance.Text);
            otrate = float.Parse(txtotrate.Text);
            othrs = float.Parse(txtothrs.Text);
            overtime = othrs * otrate;
            basepay = monthlysal + allowance + overtime;
            txtbasepay.Text = basepay.ToString();
            txtovertime.Text = overtime.ToString();

            //GROSS PAY CALCULATION
            taxrate = float.Parse(txtgovtax.Text);
            nopay = float.Parse(txtnopay.Text);
            tax = basepay * taxrate / 100;
            grosspay = basepay - (nopay + tax);
            txtgrosspay.Text = grosspay.ToString();


        }

        private void cycleenddate_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            query = "SELECT * FROM Settings WHERE SalCycleStartDate='" +dtcyclestartdate.Value + "' AND SalCycleEndDate='" + dtcycleenddate.Value + "'";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                DateTime stdate, enddate;
                TimeSpan gap;
                int daterange;
                stdate = DateTime.Parse(dtcyclestartdate.Text);
                enddate = DateTime.Parse(dtcycleenddate.Text);
                gap = enddate - stdate;
                daterange = gap.Days;
                txtcycledaterange.Text = daterange.ToString();

            }
            else
            {
                MessageBox.Show("Invalid Selection");
                txtcycledaterange.Clear();
            }
            con.Close();

        }

        private void btnconfirmsalary_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "insert into PayRoll (EID,FName,LName,BasePay,Allowance,OverTime,GrossPay,NoPay,PaymentDate)values ('" + txteid.Text + "','" + txtfname.Text + "','" + txtlastname.Text + "','" + txtbasepay.Text + "','" + txtallowance.Text + "','" + txtovertime.Text + "','" + txtgrosspay.Text + "','" + txtnopay.Text + "','" + dtpaydate.Value + "')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Payroll Record Added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btnviewreport_Click(object sender, EventArgs e)
        {
            
            PayRollReport pr = new PayRollReport();
            pr.ShowDialog();
        }

        private void txtattendance_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtabsentdays_TextChanged(object sender, EventArgs e)
        {
            int absentdays, overallattendance, cycledaterange;
            absentdays = int.Parse(txtabsentdays.Text);
            cycledaterange = int.Parse(txtcycledaterange.Text);
            overallattendance = cycledaterange - absentdays;
            txtattendance.Text = overallattendance.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
