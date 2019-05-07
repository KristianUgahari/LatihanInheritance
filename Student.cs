using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Student : Person
    {
        public Student(string nama, int umur, string studentid, string email) : base(nama, umur)
        {
            StudentId = studentid;
            Email = email;
        }

        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}
