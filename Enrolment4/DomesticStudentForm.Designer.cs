
namespace Enrolment4
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
            this.loanLabel.Location = new System.Drawing.Point(72, 314);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(60, 25);
            this.loanLabel.TabIndex = 12;
            this.loanLabel.Text = "Loan";
            // 
            // loan
            // 
            this.loan.Location = new System.Drawing.Point(149, 309);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(100, 31);
            this.loan.TabIndex = 13;
            // 
            // fullTime
            // 
            this.fullTime.AutoSize = true;
            this.fullTime.Location = new System.Drawing.Point(149, 372);
            this.fullTime.Name = "fullTime";
            this.fullTime.Size = new System.Drawing.Size(125, 29);
            this.fullTime.TabIndex = 14;
            this.fullTime.Text = "Full time";
            this.fullTime.UseVisualStyleBackColor = true;
            // 
            // DomesticStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1028, 460);
            this.Controls.Add(this.fullTime);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.loanLabel);
            this.Name = "DomesticStudentForm";
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
