using System;

namespace Enrolment4
{
    public partial class DomesticStudentForm : StudentForm
    {
        public DomesticStudentForm()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            DomesticStudent studentCopy = (DomesticStudent)_student;
            loan.Text = Convert.ToString(studentCopy.LoanAmount);
            fullTime.Checked = studentCopy.FullTime;
        }

        protected override void PushData()
        {
            base.PushData();

            DomesticStudent studentCopy = (DomesticStudent)_student;
            studentCopy.LoanAmount = Convert.ToDecimal(loan.Text);
            studentCopy.FullTime = fullTime.Checked;
        }
    }
}
