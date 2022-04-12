using System;
using System.Windows.Forms;

namespace Enrolment2
{
    public partial class MainForm : Form
    {
        private Student _student;
        private Student _studentCopy;
        private StudentForm _studentForm = new StudentForm();

        public Student Student { get => _student; set => _student = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            _studentCopy = _student;
            _student = new Student();
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
                    _student = new Student();
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
