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
    public partial class AddCow : Form
    {
        FeedManager cw;

        public AddCow(FeedManager cw)
        {
            this.cw = cw;
            InitializeComponent();
        }

        private void lblAddCowTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnToAddFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFoodConsumptionForm myNewForm = new AddFoodConsumptionForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
