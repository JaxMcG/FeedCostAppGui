
namespace FeedCostAppGui
{
    partial class SearchForCowForm
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
            this.cbxSearchBar = new System.Windows.Forms.ComboBox();
            this.rdbFilterFriesian = new System.Windows.Forms.RadioButton();
            this.rdbFilterJersey = new System.Windows.Forms.RadioButton();
            this.rdbFilterAyrshire = new System.Windows.Forms.RadioButton();
            this.lblSearchForCow = new System.Windows.Forms.Label();
            this.rtbDisplaySearchedCowSum = new System.Windows.Forms.RichTextBox();
            this.btnToHomeFromSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSearchBar
            // 
            this.cbxSearchBar.FormattingEnabled = true;
            this.cbxSearchBar.Location = new System.Drawing.Point(136, 199);
            this.cbxSearchBar.Name = "cbxSearchBar";
            this.cbxSearchBar.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchBar.TabIndex = 0;
            this.cbxSearchBar.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBar_SelectedIndexChanged);
            // 
            // rdbFilterFriesian
            // 
            this.rdbFilterFriesian.AutoSize = true;
            this.rdbFilterFriesian.Location = new System.Drawing.Point(12, 177);
            this.rdbFilterFriesian.Name = "rdbFilterFriesian";
            this.rdbFilterFriesian.Size = new System.Drawing.Size(61, 17);
            this.rdbFilterFriesian.TabIndex = 1;
            this.rdbFilterFriesian.TabStop = true;
            this.rdbFilterFriesian.Text = "Friesian";
            this.rdbFilterFriesian.UseVisualStyleBackColor = true;
            this.rdbFilterFriesian.CheckedChanged += new System.EventHandler(this.rdbFilterFriesian_CheckedChanged);
            // 
            // rdbFilterJersey
            // 
            this.rdbFilterJersey.AutoSize = true;
            this.rdbFilterJersey.Location = new System.Drawing.Point(12, 200);
            this.rdbFilterJersey.Name = "rdbFilterJersey";
            this.rdbFilterJersey.Size = new System.Drawing.Size(55, 17);
            this.rdbFilterJersey.TabIndex = 2;
            this.rdbFilterJersey.TabStop = true;
            this.rdbFilterJersey.Text = "Jersey";
            this.rdbFilterJersey.UseVisualStyleBackColor = true;
            this.rdbFilterJersey.CheckedChanged += new System.EventHandler(this.rdbFilterJersey_CheckedChanged);
            // 
            // rdbFilterAyrshire
            // 
            this.rdbFilterAyrshire.AutoSize = true;
            this.rdbFilterAyrshire.Location = new System.Drawing.Point(12, 223);
            this.rdbFilterAyrshire.Name = "rdbFilterAyrshire";
            this.rdbFilterAyrshire.Size = new System.Drawing.Size(62, 17);
            this.rdbFilterAyrshire.TabIndex = 3;
            this.rdbFilterAyrshire.TabStop = true;
            this.rdbFilterAyrshire.Text = "Ayrshire";
            this.rdbFilterAyrshire.UseVisualStyleBackColor = true;
            this.rdbFilterAyrshire.CheckedChanged += new System.EventHandler(this.rdbFilterAyrshire_CheckedChanged);
            // 
            // lblSearchForCow
            // 
            this.lblSearchForCow.AutoSize = true;
            this.lblSearchForCow.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchForCow.Location = new System.Drawing.Point(40, 43);
            this.lblSearchForCow.Name = "lblSearchForCow";
            this.lblSearchForCow.Size = new System.Drawing.Size(524, 34);
            this.lblSearchForCow.TabIndex = 4;
            this.lblSearchForCow.Text = "Search For A Previously Added Cow";
            // 
            // rtbDisplaySearchedCowSum
            // 
            this.rtbDisplaySearchedCowSum.Location = new System.Drawing.Point(529, 111);
            this.rtbDisplaySearchedCowSum.Name = "rtbDisplaySearchedCowSum";
            this.rtbDisplaySearchedCowSum.Size = new System.Drawing.Size(259, 327);
            this.rtbDisplaySearchedCowSum.TabIndex = 5;
            this.rtbDisplaySearchedCowSum.Text = "";
            // 
            // btnToHomeFromSearch
            // 
            this.btnToHomeFromSearch.Location = new System.Drawing.Point(12, 389);
            this.btnToHomeFromSearch.Name = "btnToHomeFromSearch";
            this.btnToHomeFromSearch.Size = new System.Drawing.Size(182, 49);
            this.btnToHomeFromSearch.TabIndex = 6;
            this.btnToHomeFromSearch.Text = "Back To Home Screen";
            this.btnToHomeFromSearch.UseVisualStyleBackColor = true;
            this.btnToHomeFromSearch.Click += new System.EventHandler(this.btnToHomeFromSearch_Click);
            // 
            // SearchForCowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToHomeFromSearch);
            this.Controls.Add(this.rtbDisplaySearchedCowSum);
            this.Controls.Add(this.lblSearchForCow);
            this.Controls.Add(this.rdbFilterAyrshire);
            this.Controls.Add(this.rdbFilterJersey);
            this.Controls.Add(this.rdbFilterFriesian);
            this.Controls.Add(this.cbxSearchBar);
            this.Name = "SearchForCowForm";
            this.Text = "SearchForCowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSearchBar;
        private System.Windows.Forms.RadioButton rdbFilterFriesian;
        private System.Windows.Forms.RadioButton rdbFilterJersey;
        private System.Windows.Forms.RadioButton rdbFilterAyrshire;
        private System.Windows.Forms.Label lblSearchForCow;
        private System.Windows.Forms.RichTextBox rtbDisplaySearchedCowSum;
        private System.Windows.Forms.Button btnToHomeFromSearch;
    }
}