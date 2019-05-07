using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor
            Person person = new Person("Kristian", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Ugahari", 20, "2296", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Dwipa", 18, "1234", "kristian.dwipa@students.amikom.ac.id");
            student.GetNameAndAge();
            
            /*Person person = new Person();
            person.Name = "Kristian";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Ugahari";
            teacher.Age = 20;
            teacher.TeacherId = "2296";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Dwipa";
            student.Age = 18;
            student.StudentId = "1234";
            student.Email = "kristian.dwipa@students.amikom.ac.id";
            student.GetNameAndAge();*/

            Console.ReadKey();
        }
    }
}
