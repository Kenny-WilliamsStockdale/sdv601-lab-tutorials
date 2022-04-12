using System;

namespace Enrolment4
{
    class DomesticStudent : Student
    {
        private decimal _loanAmount;
        private bool _fullTime;
        private static DomesticStudentForm _form = new DomesticStudentForm();

        public decimal LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        public bool FullTime { get => _fullTime; set => _fullTime = value; }

        public override bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }
    }
}
