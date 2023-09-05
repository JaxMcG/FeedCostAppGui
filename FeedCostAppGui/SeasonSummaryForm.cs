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
    public partial class SeasonSummaryForm : Form
    {
        FeedManager fm;

        public SeasonSummaryForm(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();



            float[,] seasonConsumption = fm.CalculateSeasonConsumption();

            rtbSummerStats.Text = $"Palm Kernal Consumed: {seasonConsumption[0, 0]}\n" +
                $"Maize Consumed: {seasonConsumption[1, 0]}\n" +
                $"Hay Consumed: {seasonConsumption[2, 0]}";

            rtbAutumnStats.Text = $"Palm Kernal Consumed: {seasonConsumption[0, 1]}\n" +
                $"Maize Consumed: {seasonConsumption[1, 1]}\n" +
                $"Hay Consumed: {seasonConsumption[2, 1]}";

            rtbWinterStats.Text = $"Palm Kernal Consumed: {seasonConsumption[0, 2]}\n" +
                $"Maize Consumed: {seasonConsumption[1, 2]}\n" +
                $"Hay Consumed: {seasonConsumption[2, 2]}";

            rtbSpringStats.Text = $"Palm Kernal Consumed: {seasonConsumption[0, 3]}\n" +
                $"Maize Consumed: {seasonConsumption[1, 3]}\n" +
                $"Hay Consumed: {seasonConsumption[2, 3]}";

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }


        private void SeasonSummaryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
