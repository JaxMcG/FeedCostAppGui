
namespace FeedCostAppGui
{
    partial class AddCow
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
            this.lblAddCowTitle = new System.Windows.Forms.Label();
            this.cbxBreedChoice = new System.Windows.Forms.ComboBox();
            this.cbxFoodChoice = new System.Windows.Forms.ComboBox();
            this.lblSpeciesSubTitle = new System.Windows.Forms.Label();
            this.lblBreesSubTitle = new System.Windows.Forms.Label();
            this.lblFoodChoice = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.rtbShowFoodPrice = new System.Windows.Forms.RichTextBox();
            this.btnToAddFood = new System.Windows.Forms.Button();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddCowTitle
            // 
            this.lblAddCowTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCowTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAddCowTitle.Name = "lblAddCowTitle";
            this.lblAddCowTitle.Size = new System.Drawing.Size(776, 80);
            this.lblAddCowTitle.TabIndex = 0;
            this.lblAddCowTitle.Text = "Add A New Cow";
            this.lblAddCowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddCowTitle.Click += new System.EventHandler(this.lblAddCowTitle_Click);
            // 
            // cbxBreedChoice
            // 
            this.cbxBreedChoice.FormattingEnabled = true;
            this.cbxBreedChoice.Location = new System.Drawing.Point(12, 171);
            this.cbxBreedChoice.Name = "cbxBreedChoice";
            this.cbxBreedChoice.Size = new System.Drawing.Size(154, 21);
            this.cbxBreedChoice.TabIndex = 1;
            // 
            // cbxFoodChoice
            // 
            this.cbxFoodChoice.FormattingEnabled = true;
            this.cbxFoodChoice.Location = new System.Drawing.Point(12, 238);
            this.cbxFoodChoice.Name = "cbxFoodChoice";
            this.cbxFoodChoice.Size = new System.Drawing.Size(154, 21);
            this.cbxFoodChoice.TabIndex = 2;
            // 
            // lblSpeciesSubTitle
            // 
            this.lblSpeciesSubTitle.AutoSize = true;
            this.lblSpeciesSubTitle.Location = new System.Drawing.Point(12, 120);
            this.lblSpeciesSubTitle.Name = "lblSpeciesSubTitle";
            this.lblSpeciesSubTitle.Size = new System.Drawing.Size(72, 13);
            this.lblSpeciesSubTitle.TabIndex = 5;
            this.lblSpeciesSubTitle.Text = "Species: Cow";
            // 
            // lblBreesSubTitle
            // 
            this.lblBreesSubTitle.AutoSize = true;
            this.lblBreesSubTitle.Location = new System.Drawing.Point(12, 155);
            this.lblBreesSubTitle.Name = "lblBreesSubTitle";
            this.lblBreesSubTitle.Size = new System.Drawing.Size(35, 13);
            this.lblBreesSubTitle.TabIndex = 6;
            this.lblBreesSubTitle.Text = "Breed";
            // 
            // lblFoodChoice
            // 
            this.lblFoodChoice.AutoSize = true;
            this.lblFoodChoice.Location = new System.Drawing.Point(12, 222);
            this.lblFoodChoice.Name = "lblFoodChoice";
            this.lblFoodChoice.Size = new System.Drawing.Size(70, 13);
            this.lblFoodChoice.TabIndex = 7;
            this.lblFoodChoice.Text = "Type of Food";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(12, 289);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(70, 13);
            this.lblFoodPrice.TabIndex = 8;
            this.lblFoodPrice.Text = "Price of Food";
            // 
            // rtbShowFoodPrice
            // 
            this.rtbShowFoodPrice.Location = new System.Drawing.Point(12, 305);
            this.rtbShowFoodPrice.Name = "rtbShowFoodPrice";
            this.rtbShowFoodPrice.Size = new System.Drawing.Size(154, 21);
            this.rtbShowFoodPrice.TabIndex = 9;
            this.rtbShowFoodPrice.Text = "";
            // 
            // btnToAddFood
            // 
            this.btnToAddFood.Location = new System.Drawing.Point(12, 395);
            this.btnToAddFood.Name = "btnToAddFood";
            this.btnToAddFood.Size = new System.Drawing.Size(154, 43);
            this.btnToAddFood.TabIndex = 10;
            this.btnToAddFood.Text = "Food Consumption";
            this.btnToAddFood.UseVisualStyleBackColor = true;
            this.btnToAddFood.Click += new System.EventHandler(this.btnToAddFood_Click);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(634, 395);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(154, 43);
            this.btnBackToHome.TabIndex = 11;
            this.btnBackToHome.Text = "Back to Home Screen";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // AddCow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.btnToAddFood);
            this.Controls.Add(this.rtbShowFoodPrice);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodChoice);
            this.Controls.Add(this.lblBreesSubTitle);
            this.Controls.Add(this.lblSpeciesSubTitle);
            this.Controls.Add(this.cbxFoodChoice);
            this.Controls.Add(this.cbxBreedChoice);
            this.Controls.Add(this.lblAddCowTitle);
            this.Name = "AddCow";
            this.Text = "AddCow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCowTitle;
        private System.Windows.Forms.ComboBox cbxBreedChoice;
        private System.Windows.Forms.ComboBox cbxFoodChoice;
        private System.Windows.Forms.Label lblSpeciesSubTitle;
        private System.Windows.Forms.Label lblBreesSubTitle;
        private System.Windows.Forms.Label lblFoodChoice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.RichTextBox rtbShowFoodPrice;
        private System.Windows.Forms.Button btnToAddFood;
        private System.Windows.Forms.Button btnBackToHome;
    }
}