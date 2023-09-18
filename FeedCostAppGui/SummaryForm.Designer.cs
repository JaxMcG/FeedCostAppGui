
namespace FeedCostAppGui
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.rtbSumStatsPerCow = new System.Windows.Forms.RichTextBox();
            this.btnToHomeScreen = new System.Windows.Forms.Button();
            this.btnToTotalSumFromSingleSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.White;
            this.lblSummaryTitle.Location = new System.Drawing.Point(398, 41);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(283, 34);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Summary Statistics";
            // 
            // rtbSumStatsPerCow
            // 
            this.rtbSumStatsPerCow.Location = new System.Drawing.Point(12, 12);
            this.rtbSumStatsPerCow.Name = "rtbSumStatsPerCow";
            this.rtbSumStatsPerCow.Size = new System.Drawing.Size(270, 426);
            this.rtbSumStatsPerCow.TabIndex = 1;
            this.rtbSumStatsPerCow.Text = "";
            // 
            // btnToHomeScreen
            // 
            this.btnToHomeScreen.Location = new System.Drawing.Point(606, 388);
            this.btnToHomeScreen.Name = "btnToHomeScreen";
            this.btnToHomeScreen.Size = new System.Drawing.Size(182, 49);
            this.btnToHomeScreen.TabIndex = 2;
            this.btnToHomeScreen.Text = "Back To Home Screen";
            this.btnToHomeScreen.UseVisualStyleBackColor = true;
            this.btnToHomeScreen.Click += new System.EventHandler(this.btnToHomeScreen_Click);
            // 
            // btnToTotalSumFromSingleSum
            // 
            this.btnToTotalSumFromSingleSum.Location = new System.Drawing.Point(606, 333);
            this.btnToTotalSumFromSingleSum.Name = "btnToTotalSumFromSingleSum";
            this.btnToTotalSumFromSingleSum.Size = new System.Drawing.Size(182, 49);
            this.btnToTotalSumFromSingleSum.TabIndex = 3;
            this.btnToTotalSumFromSingleSum.Text = "To Total Summary";
            this.btnToTotalSumFromSingleSum.UseVisualStyleBackColor = true;
            this.btnToTotalSumFromSingleSum.Click += new System.EventHandler(this.btnToTotalSumFromSingleSum_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedCostAppGui.Properties.Resources.desktop_wallpaper_green_farm_vietnam_ultra_high_quality_walls;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToTotalSumFromSingleSum);
            this.Controls.Add(this.btnToHomeScreen);
            this.Controls.Add(this.rtbSumStatsPerCow);
            this.Controls.Add(this.lblSummaryTitle);
            this.Name = "SummaryForm";
            this.Text = "77";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.RichTextBox rtbSumStatsPerCow;
        private System.Windows.Forms.Button btnToHomeScreen;
        private System.Windows.Forms.Button btnToTotalSumFromSingleSum;
    }
}