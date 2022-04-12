using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment4
{
    public class Institute
    {
        private static List<Student> _studentList = new List<Student>();

        public static List<Student> StudentList { get => _studentList;}
    }
}
