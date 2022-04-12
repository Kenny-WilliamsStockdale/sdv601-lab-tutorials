using System;
using System.Windows.Forms;

namespace Enrolment2
{
    public partial class StudentForm : Form
    {
        private Student _student;

        public StudentForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Student student)
        {
            _student = student;
            UpdateDisplay();

            return ShowDialog();
        }

        private void UpdateDisplay()
        {
            id.Text = _student.ID;
            name.Text = _student.Name;
            dateOfBirth.Value = _student.DateOfBirth;
            balance.Text = Convert.ToString(_student.Balance);
            id.Enabled = String.IsNullOrEmpty(_student.ID);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _student.ID = id.Text;
            _student.Name = name.Text;
            _student.DateOfBirth = dateOfBirth.Value;
            _student.Balance = Convert.ToDecimal(balance.Text);
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
