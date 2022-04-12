namespace Enrolment3
{
    partial class StudentForm
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
            System.Windows.Forms.ListBox programmes;
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.programmesLabel = new System.Windows.Forms.Label();
            programmes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // programmes
            // 
            programmes.FormattingEnabled = true;
            programmes.ItemHeight = 25;
            programmes.Location = new System.Drawing.Point(674, 66);
            programmes.Name = "programmes";
            programmes.Size = new System.Drawing.Size(312, 254);
            programmes.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(149, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(338, 31);
            this.id.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(149, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(464, 31);
            this.name.TabIndex = 1;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(149, 239);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 31);
            this.balance.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(733, 372);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 40);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(871, 372);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(149, 167);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(464, 31);
            this.dateOfBirth.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(111, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 25);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(75, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(12, 171);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(131, 25);
            this.dateOfBirthLabel.TabIndex = 9;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(35, 245);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(108, 25);
            this.balanceLabel.TabIndex = 10;
            this.balanceLabel.Text = "Balance $";
            // 
            // programmesLabel
            // 
            this.programmesLabel.AutoSize = true;
            this.programmesLabel.Location = new System.Drawing.Point(669, 23);
            this.programmesLabel.Name = "programmesLabel";
            this.programmesLabel.Size = new System.Drawing.Size(133, 25);
            this.programmesLabel.TabIndex = 11;
            this.programmesLabel.Text = "Programmes";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 460);
            this.Controls.Add(this.programmesLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(programmes);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentForm";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label programmesLabel;
    }
}