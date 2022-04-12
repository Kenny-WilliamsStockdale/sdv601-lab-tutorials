using System;
using System.Windows.Forms;

namespace Enrolment4
{
    public partial class MainForm : Form
    {
        private Student _student;

        public Student Student { get => _student; set => _student = value; }

        public MainForm()
        {
            InitializeComponent();

            studentType.DataSource = Student.Types;
            studentType.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            Student student = Student.NewStudent((StudentType)studentType.SelectedItem);
            EditStudent(student);
        }

        private void modifyStudentButton_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                EditStudent(_student);
            }
            else
            {
                if (MessageBox.Show("Would you like to create a new Student?", "Create new Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Student student = Student.NewStudent((StudentType)studentType.SelectedItem);
                    EditStudent(student);
                }
            }
        }

        private void EditStudent(Student student)
        {
            if (student != null && student.ViewEdit())
            {
                _student = student;
                studentDetails.Text = "Student:\n" + _student.ToString();
            }
        }
    }
}
