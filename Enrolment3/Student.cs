namespace Enrolment3
{
    public abstract class Student
    {
        private string _id;
        private string _name;
        private DateTime _dateOfBirth = DateTime.Today;
        private decimal _balance;

        /// <summary>
        /// The student ID
        /// </summary>
        public string ID { get => _id; set => _id = value; }

        /// <summary>
        /// The student name
        /// </summary>
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// The date of birth
        /// </summary>
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

        /// <summary>
        /// The balance of the student account in dollars
        /// </summary>
        public decimal Balance { get => _balance; set => _balance = value; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}", ID, Name);
        }
    }
}