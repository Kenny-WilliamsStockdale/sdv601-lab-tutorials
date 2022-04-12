namespace Enrolment2
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
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(27, 27);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(236, 50);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // modifyStudentButton
            // 
            this.modifyStudentButton.Location = new System.Drawing.Point(27, 96);
            this.modifyStudentButton.Name = "modifyStudentButton";
            this.modifyStudentButton.Size = new System.Drawing.Size(236, 50);
            this.modifyStudentButton.TabIndex = 1;
            this.modifyStudentButton.Text = "Modify Student";
            this.modifyStudentButton.UseVisualStyleBackColor = true;
            this.modifyStudentButton.Click += new System.EventHandler(this.modifyStudentButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(461, 290);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 51);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // studentDetails
            // 
            this.studentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentDetails.Location = new System.Drawing.Point(27, 185);
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Size = new System.Drawing.Size(236, 156);
            this.studentDetails.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 365);
            this.Controls.Add(this.studentDetails);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.modifyStudentButton);
            this.Controls.Add(this.createStudentButton);
            this.Name = "MainForm";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Button modifyStudentButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label studentDetails;
    }
}

