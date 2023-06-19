
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
            this.btnToSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.Location = new System.Drawing.Point(12, 9);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(776, 97);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Home";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCow
            // 
            this.btnAddCow.Location = new System.Drawing.Point(315, 169);
            this.btnAddCow.Name = "btnAddCow";
            this.btnAddCow.Size = new System.Drawing.Size(164, 49);
            this.btnAddCow.TabIndex = 1;
            this.btnAddCow.Text = "Add a Cow";
            this.btnAddCow.UseVisualStyleBackColor = true;
            this.btnAddCow.Click += new System.EventHandler(this.btnAddCow_Click);
            // 
            // btnToSummary
            // 
            this.btnToSummary.Location = new System.Drawing.Point(315, 224);
            this.btnToSummary.Name = "btnToSummary";
            this.btnToSummary.Size = new System.Drawing.Size(164, 49);
            this.btnToSummary.TabIndex = 2;
            this.btnToSummary.Text = "Summary";
            this.btnToSummary.UseVisualStyleBackColor = true;
            this.btnToSummary.Click += new System.EventHandler(this.btnToSummary_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToSummary);
            this.Controls.Add(this.btnAddCow);
            this.Controls.Add(this.lblHomeTitle);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnAddCow;
        private System.Windows.Forms.Button btnToSummary;
    }
}

