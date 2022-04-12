namespace Enrolment3
{
    class DomesticStudent : Student
    {
        private decimal _loanAmount;
        private bool _fullTime;

        public decimal LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        public bool FullTime { get => _fullTime; set => _fullTime = value; }
    }
}
