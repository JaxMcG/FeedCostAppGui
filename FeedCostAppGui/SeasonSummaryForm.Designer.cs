
namespace FeedCostAppGui
{
    partial class SeasonSummaryForm
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
            this.lblSeasonSummaryTitle = new System.Windows.Forms.Label();
            this.rtbSummerStats = new System.Windows.Forms.RichTextBox();
            this.rtbAutumnStats = new System.Windows.Forms.RichTextBox();
            this.rtbWinterStats = new System.Windows.Forms.RichTextBox();
            this.rtbSpringStats = new System.Windows.Forms.RichTextBox();
            this.lblSummerStats = new System.Windows.Forms.Label();
            this.lblAutumnStats = new System.Windows.Forms.Label();
            this.lblWinterStats = new System.Windows.Forms.Label();
            this.lblSpringStats = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeasonSummaryTitle
            // 
            this.lblSeasonSummaryTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeasonSummaryTitle.ForeColor = System.Drawing.Color.White;
            this.lblSeasonSummaryTitle.Location = new System.Drawing.Point(12, 15);
            this.lblSeasonSummaryTitle.Name = "lblSeasonSummaryTitle";
            this.lblSeasonSummaryTitle.Size = new System.Drawing.Size(776, 34);
            this.lblSeasonSummaryTitle.TabIndex = 4;
            this.lblSeasonSummaryTitle.Text = "Total Summary Statistics For Each Season";
            this.lblSeasonSummaryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbSummerStats
            // 
            this.rtbSummerStats.Location = new System.Drawing.Point(12, 103);
            this.rtbSummerStats.Name = "rtbSummerStats";
            this.rtbSummerStats.ReadOnly = true;
            this.rtbSummerStats.Size = new System.Drawing.Size(175, 290);
            this.rtbSummerStats.TabIndex = 5;
            this.rtbSummerStats.Text = "";
            // 
            // rtbAutumnStats
            // 
            this.rtbAutumnStats.Location = new System.Drawing.Point(211, 103);
            this.rtbAutumnStats.Name = "rtbAutumnStats";
            this.rtbAutumnStats.ReadOnly = true;
            this.rtbAutumnStats.Size = new System.Drawing.Size(175, 290);
            this.rtbAutumnStats.TabIndex = 6;
            this.rtbAutumnStats.Text = "";
            // 
            // rtbWinterStats
            // 
            this.rtbWinterStats.Location = new System.Drawing.Point(412, 103);
            this.rtbWinterStats.Name = "rtbWinterStats";
            this.rtbWinterStats.ReadOnly = true;
            this.rtbWinterStats.Size = new System.Drawing.Size(175, 290);
            this.rtbWinterStats.TabIndex = 7;
            this.rtbWinterStats.Text = "";
            // 
            // rtbSpringStats
            // 
            this.rtbSpringStats.Location = new System.Drawing.Point(613, 103);
            this.rtbSpringStats.Name = "rtbSpringStats";
            this.rtbSpringStats.ReadOnly = true;
            this.rtbSpringStats.Size = new System.Drawing.Size(175, 290);
            this.rtbSpringStats.TabIndex = 8;
            this.rtbSpringStats.Text = "";
            // 
            // lblSummerStats
            // 
            this.lblSummerStats.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummerStats.ForeColor = System.Drawing.Color.White;
            this.lblSummerStats.Location = new System.Drawing.Point(12, 77);
            this.lblSummerStats.Name = "lblSummerStats";
            this.lblSummerStats.Size = new System.Drawing.Size(175, 23);
            this.lblSummerStats.TabIndex = 9;
            this.lblSummerStats.Text = "Summer Statistics";
            this.lblSummerStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAutumnStats
            // 
            this.lblAutumnStats.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblAutumnStats.ForeColor = System.Drawing.Color.White;
            this.lblAutumnStats.Location = new System.Drawing.Point(214, 77);
            this.lblAutumnStats.Name = "lblAutumnStats";
            this.lblAutumnStats.Size = new System.Drawing.Size(175, 23);
            this.lblAutumnStats.TabIndex = 10;
            this.lblAutumnStats.Text = "Autumn Statistics";
            this.lblAutumnStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWinterStats
            // 
            this.lblWinterStats.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblWinterStats.ForeColor = System.Drawing.Color.White;
            this.lblWinterStats.Location = new System.Drawing.Point(417, 77);
            this.lblWinterStats.Name = "lblWinterStats";
            this.lblWinterStats.Size = new System.Drawing.Size(175, 23);
            this.lblWinterStats.TabIndex = 11;
            this.lblWinterStats.Text = "Winter Statistics";
            this.lblWinterStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSpringStats
            // 
            this.lblSpringStats.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblSpringStats.ForeColor = System.Drawing.Color.White;
            this.lblSpringStats.Location = new System.Drawing.Point(613, 77);
            this.lblSpringStats.Name = "lblSpringStats";
            this.lblSpringStats.Size = new System.Drawing.Size(175, 23);
            this.lblSpringStats.TabIndex = 12;
            this.lblSpringStats.Text = "Spring Statistics";
            this.lblSpringStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(613, 400);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(175, 38);
            this.btnBackToHome.TabIndex = 13;
            this.btnBackToHome.Text = "Back";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // SeasonSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedCostAppGui.Properties.Resources.desktop_wallpaper_green_farm_vietnam_ultra_high_quality_walls;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.lblSpringStats);
            this.Controls.Add(this.lblWinterStats);
            this.Controls.Add(this.lblAutumnStats);
            this.Controls.Add(this.lblSummerStats);
            this.Controls.Add(this.rtbSpringStats);
            this.Controls.Add(this.rtbWinterStats);
            this.Controls.Add(this.rtbAutumnStats);
            this.Controls.Add(this.rtbSummerStats);
            this.Controls.Add(this.lblSeasonSummaryTitle);
            this.Name = "SeasonSummaryForm";
            this.Text = "SeasonSummaryForm";
            this.Load += new System.EventHandler(this.SeasonSummaryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSeasonSummaryTitle;
        private System.Windows.Forms.RichTextBox rtbSummerStats;
        private System.Windows.Forms.RichTextBox rtbAutumnStats;
        private System.Windows.Forms.RichTextBox rtbWinterStats;
        private System.Windows.Forms.RichTextBox rtbSpringStats;
        private System.Windows.Forms.Label lblSummerStats;
        private System.Windows.Forms.Label lblAutumnStats;
        private System.Windows.Forms.Label lblWinterStats;
        private System.Windows.Forms.Label lblSpringStats;
        private System.Windows.Forms.Button btnBackToHome;
    }
}