﻿using System;
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
    public partial class AddFoodConsumptionForm : Form
    {
        FeedManager fm;

        public AddFoodConsumptionForm(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm myNewForm = new SummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
