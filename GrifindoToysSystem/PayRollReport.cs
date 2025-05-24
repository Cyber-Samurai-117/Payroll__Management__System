using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysSystem
{
    public partial class PayRollReport : Form
    {
        public PayRollReport()
        {
            InitializeComponent();
        }

        private void PayRollReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PayRollDataSet.PayRoll' table. You can move, or remove it, as needed.
            //this.PayRollTableAdapter.Fill(this.PayRollDataSet.PayRoll);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
