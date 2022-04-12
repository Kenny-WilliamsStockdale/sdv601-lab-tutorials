namespace Enrolment4
{
    class InternationalStudent : Student
    {
        private string _country;
        private float _itelsScore;
        private static InternationalStudentForm _form = new InternationalStudentForm();

        public float ItelsScore { get => _itelsScore; set => _itelsScore = value; }
        public string Country { get => _country; set => _country = value; }

        public override bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }
    }
}
