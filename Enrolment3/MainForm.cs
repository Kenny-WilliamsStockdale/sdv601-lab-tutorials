namespace Enrolment3
{
    public partial class MainForm : Form
    {
        private Student _student;
        private Student _studentCopy;
        private StudentForm _studentForm;
        private DomesticStudentForm _domesticStudentForm = new DomesticStudentForm();
        private InternationalStudentForm _internationalStudentForm = new InternationalStudentForm();
        private string[] _studentType = { "Domestic", "International" };


        public Student Student { get => _student; set => _student = value; }

        public MainForm()
        {
            InitializeComponent();

            studentType.DataSource = _studentType;
            studentType.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            _studentCopy = _student;
            if (studentType.SelectedIndex == 0)
            {
                _studentForm = _domesticStudentForm;
                _student = new DomesticStudent();
            }
            else
            {
                _studentForm = _internationalStudentForm;
                _student = new InternationalStudent();
            }

            EditStudent();
        }

        private void modifyStudentButton_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                _studentCopy = _student;
                EditStudent();
            }
            else
            {
                if (MessageBox.Show("Would you like to create a new Student?", "Create new Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EditStudent();
                }
            }
        }

        private void EditStudent()
        {
            if (_student != null && _studentForm.ShowDialog(_student) == DialogResult.OK)
            {
                studentDetails.Text = "Student:\n" + _student.ToString();
            }
            else
            {
                _student = _studentCopy;
            }
        }
    }
}
