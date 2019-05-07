using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor
        public Person(string nama, int umur) {
            Name = nama;
            Age = umur;
        }
 
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
    }
}
