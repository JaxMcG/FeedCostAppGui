using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedCostAppGui
{
    public partial class SummaryForm : Form
    {
        FeedManager cw;

        public SummaryForm(FeedManager cw)
        {
            this.cw = cw;
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnToHomeScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
