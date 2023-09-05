
namespace FeedCostAppGui
{
    partial class HomeForm
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
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnAddCow = new System.Windows.Forms.Button();
            this.btnToTotalSummary = new System.Windows.Forms.Button();
            this.btnSearchCow = new System.Windows.Forms.Button();
            this.btnToSeasonSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.ForeColor = System.Drawing.Color.White;
            this.lblHomeTitle.Location = new System.Drawing.Point(12, 9);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(776, 97);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Home";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCow
            // 
            this.btnAddCow.ForeColor = System.Drawing.Color.Black;
            this.btnAddCow.Location = new System.Drawing.Point(315, 99);
            this.btnAddCow.Name = "btnAddCow";
            this.btnAddCow.Size = new System.Drawing.Size(164, 49);
            this.btnAddCow.TabIndex = 1;
            this.btnAddCow.Text = "Add a Cow";
            this.btnAddCow.UseVisualStyleBackColor = true;
            this.btnAddCow.Click += new System.EventHandler(this.btnAddCow_Click);
            // 
            // btnToTotalSummary
            // 
            this.btnToTotalSummary.ForeColor = System.Drawing.Color.Black;
            this.btnToTotalSummary.Location = new System.Drawing.Point(315, 209);
            this.btnToTotalSummary.Name = "btnToTotalSummary";
            this.btnToTotalSummary.Size = new System.Drawing.Size(164, 49);
            this.btnToTotalSummary.TabIndex = 3;
            this.btnToTotalSummary.Text = "Total Summary";
            this.btnToTotalSummary.UseVisualStyleBackColor = true;
            this.btnToTotalSummary.Click += new System.EventHandler(this.btnToTotalSummary_Click);
            // 
            // btnSearchCow
            // 
            this.btnSearchCow.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCow.Location = new System.Drawing.Point(315, 154);
            this.btnSearchCow.Name = "btnSearchCow";
            this.btnSearchCow.Size = new System.Drawing.Size(164, 49);
            this.btnSearchCow.TabIndex = 5;
            this.btnSearchCow.Text = "Search For A Cow";
            this.btnSearchCow.UseVisualStyleBackColor = true;
            this.btnSearchCow.Click += new System.EventHandler(this.btnSearchCow_Click);
            // 
            // btnToSeasonSum
            // 
            this.btnToSeasonSum.ForeColor = System.Drawing.Color.Black;
            this.btnToSeasonSum.Location = new System.Drawing.Point(315, 264);
            this.btnToSeasonSum.Name = "btnToSeasonSum";
            this.btnToSeasonSum.Size = new System.Drawing.Size(164, 49);
            this.btnToSeasonSum.TabIndex = 6;
            this.btnToSeasonSum.Text = "Season Summaries";
            this.btnToSeasonSum.UseVisualStyleBackColor = true;
            this.btnToSeasonSum.Click += new System.EventHandler(this.btnToSeasonSum_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedCostAppGui.Properties.Resources.desktop_wallpaper_green_farm_vietnam_ultra_high_quality_walls;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToSeasonSum);
            this.Controls.Add(this.btnSearchCow);
            this.Controls.Add(this.btnToTotalSummary);
            this.Controls.Add(this.btnAddCow);
            this.Controls.Add(this.lblHomeTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnAddCow;
        private System.Windows.Forms.Button btnToTotalSummary;
        private System.Windows.Forms.Button btnSearchCow;
        private System.Windows.Forms.Button btnToSeasonSum;
    }
}

