using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        //constructor
        public Teacher(string nama, int umur, string teacherid, string subject) : base(nama, umur)
        {
            Name = nama;
            Age = umur;
            TeacherId = teacherid;
            Subject = subject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }
    }
}
