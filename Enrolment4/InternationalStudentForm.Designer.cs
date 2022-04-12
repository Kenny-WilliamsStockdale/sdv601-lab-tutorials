
namespace Enrolment4
{
    partial class InternationalStudentForm
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
            this.country = new System.Windows.Forms.TextBox();
            this.ielts = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.ieltsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(74, 160);
            this.country.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(52, 20);
            this.country.TabIndex = 12;
            // 
            // ielts
            // 
            this.ielts.Location = new System.Drawing.Point(74, 197);
            this.ielts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ielts.Name = "ielts";
            this.ielts.Size = new System.Drawing.Size(52, 20);
            this.ielts.TabIndex = 13;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(28, 161);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 14;
            this.countryLabel.Text = "Country";
            // 
            // ieltsLabel
            // 
            this.ieltsLabel.AutoSize = true;
            this.ieltsLabel.Location = new System.Drawing.Point(35, 200);
            this.ieltsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ieltsLabel.Name = "ieltsLabel";
            this.ieltsLabel.Size = new System.Drawing.Size(37, 13);
            this.ieltsLabel.TabIndex = 15;
            this.ieltsLabel.Text = "IELTS";
            // 
            // InternationalStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(514, 239);
            this.Controls.Add(this.ieltsLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.ielts);
            this.Controls.Add(this.country);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "InternationalStudentForm";
            this.Controls.SetChildIndex(this.country, 0);
            this.Controls.SetChildIndex(this.ielts, 0);
            this.Controls.SetChildIndex(this.countryLabel, 0);
            this.Controls.SetChildIndex(this.ieltsLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox ielts;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label ieltsLabel;
    }
}
