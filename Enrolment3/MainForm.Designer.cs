namespace Enrolment3
{
    partial class MainForm
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
            this.createStudentButton = new System.Windows.Forms.Button();
            this.modifyStudentButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.studentDetails = new System.Windows.Forms.Label();
            this.studentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(14, 14);
            this.createStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(118, 26);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // modifyStudentButton
            // 
            this.modifyStudentButton.Location = new System.Drawing.Point(14, 50);
            this.modifyStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyStudentButton.Name = "modifyStudentButton";
            this.modifyStudentButton.Size = new System.Drawing.Size(118, 26);
            this.modifyStudentButton.TabIndex = 1;
            this.modifyStudentButton.Text = "Modify Student";
            this.modifyStudentButton.UseVisualStyleBackColor = true;
            this.modifyStudentButton.Click += new System.EventHandler(this.modifyStudentButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(230, 151);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 27);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // studentDetails
            // 
            this.studentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentDetails.Location = new System.Drawing.Point(14, 96);
            this.studentDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Size = new System.Drawing.Size(118, 81);
            this.studentDetails.TabIndex = 3;
            // 
            // studentType
            // 
            this.studentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentType.FormattingEnabled = true;
            this.studentType.Location = new System.Drawing.Point(158, 14);
            this.studentType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentType.Name = "studentType";
            this.studentType.Size = new System.Drawing.Size(146, 21);
            this.studentType.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 190);
            this.Controls.Add(this.studentType);
            this.Controls.Add(this.studentDetails);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.modifyStudentButton);
            this.Controls.Add(this.createStudentButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Button modifyStudentButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label studentDetails;
        private System.Windows.Forms.ComboBox studentType;
    }
}

