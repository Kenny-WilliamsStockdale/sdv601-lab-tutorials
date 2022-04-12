using System;

namespace Enrolment4
{
    public partial class InternationalStudentForm : StudentForm
    {
        public InternationalStudentForm()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            InternationalStudent studentCopy = (InternationalStudent)_student;
            country.Text = studentCopy.Country;
            ielts.Text = Convert.ToString(studentCopy.ItelsScore);
        }

        protected override void PushData()
        {
            base.PushData();

            InternationalStudent studentCopy = (InternationalStudent)_student;
            studentCopy.Country = country.Text;
            studentCopy.ItelsScore = Convert.ToSingle(ielts.Text);
        }
    }
}
