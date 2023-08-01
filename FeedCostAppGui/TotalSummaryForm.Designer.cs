
namespace FeedCostAppGui
{
    partial class TotalSummaryForm
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
            this.rtbSumStatsAllCow = new System.Windows.Forms.RichTextBox();
            this.lblTotalSummaryTitle = new System.Windows.Forms.Label();
            this.btnTotalSumToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSumStatsAllCow
            // 
            this.rtbSumStatsAllCow.Location = new System.Drawing.Point(12, 12);
            this.rtbSumStatsAllCow.Name = "rtbSumStatsAllCow";
            this.rtbSumStatsAllCow.Size = new System.Drawing.Size(270, 426);
            this.rtbSumStatsAllCow.TabIndex = 2;
            this.rtbSumStatsAllCow.Text = "";
            // 
            // lblTotalSummaryTitle
            // 
            this.lblTotalSummaryTitle.AutoSize = true;
            this.lblTotalSummaryTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSummaryTitle.Location = new System.Drawing.Point(358, 51);
            this.lblTotalSummaryTitle.Name = "lblTotalSummaryTitle";
            this.lblTotalSummaryTitle.Size = new System.Drawing.Size(367, 34);
            this.lblTotalSummaryTitle.TabIndex = 3;
            this.lblTotalSummaryTitle.Text = "Total Summary Statistics";
            // 
            // btnTotalSumToHome
            // 
            this.btnTotalSumToHome.Location = new System.Drawing.Point(606, 389);
            this.btnTotalSumToHome.Name = "btnTotalSumToHome";
            this.btnTotalSumToHome.Size = new System.Drawing.Size(182, 49);
            this.btnTotalSumToHome.TabIndex = 4;
            this.btnTotalSumToHome.Text = "Back To Home Screen";
            this.btnTotalSumToHome.UseVisualStyleBackColor = true;
            this.btnTotalSumToHome.Click += new System.EventHandler(this.btnTotalSumToHome_Click);
            // 
            // TotalSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotalSumToHome);
            this.Controls.Add(this.lblTotalSummaryTitle);
            this.Controls.Add(this.rtbSumStatsAllCow);
            this.Name = "TotalSummaryForm";
            this.Text = "TotalSummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbSumStatsAllCow;
        private System.Windows.Forms.Label lblTotalSummaryTitle;
        private System.Windows.Forms.Button btnTotalSumToHome;
    }
}