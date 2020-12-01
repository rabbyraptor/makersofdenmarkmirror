using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersOfDenmark.Models
{
    public class ViewModel
    {
        public Teacher Teacher { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }
    }
}
