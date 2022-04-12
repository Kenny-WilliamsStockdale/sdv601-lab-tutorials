namespace Enrolment3
{
    class InternationalStudent : Student
    {
        private string _country;
        private float _itelsScore;

        public float ItelsScore { get => _itelsScore; set => _itelsScore = value; }
        public string Country { get => _country; set => _country = value; }

    }
}
