
namespace Enrolment3
{
    partial class DomesticStudentForm
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
            this.loanLabel = new System.Windows.Forms.Label();
            this.loan = new System.Windows.Forms.TextBox();
            this.fullTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Location = new System.Drawing.Point(36, 163);
            this.loanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(31, 13);
            this.loanLabel.TabIndex = 12;
            this.loanLabel.Text = "Loan";
            // 
            // loan
            // 
            this.loan.Location = new System.Drawing.Point(74, 161);
            this.loan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(52, 20);
            this.loan.TabIndex = 13;
            // 
            // fullTime
            // 
            this.fullTime.AutoSize = true;
            this.fullTime.Location = new System.Drawing.Point(74, 193);
            this.fullTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullTime.Name = "fullTime";
            this.fullTime.Size = new System.Drawing.Size(64, 17);
            this.fullTime.TabIndex = 14;
            this.fullTime.Text = "Full time";
            this.fullTime.UseVisualStyleBackColor = true;
            // 
            // DomesticStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(514, 239);
            this.Controls.Add(this.fullTime);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.loanLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "DomesticStudentForm";
            this.Text = "Domestic Student";
            this.Controls.SetChildIndex(this.loanLabel, 0);
            this.Controls.SetChildIndex(this.loan, 0);
            this.Controls.SetChildIndex(this.fullTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.TextBox loan;
        private System.Windows.Forms.CheckBox fullTime;
    }
}
