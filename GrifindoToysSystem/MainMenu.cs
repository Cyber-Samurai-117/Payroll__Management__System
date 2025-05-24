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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee em = new Employee();
            em.ShowDialog();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary sa = new Salary();
            sa.ShowDialog();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings st = new Settings();
            st.ShowDialog();
        }
    }
}
