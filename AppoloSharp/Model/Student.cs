using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppoloSharp.Model
{
    public class Student
    {
        public int Id { get; protected set; }
        public int Number { get; protected set; }
        public string Name { get; protected set; }
        public string AcademicEmail { get; protected set; }

        public Student(int id, int number, string name, string academicEmail)
        {
            Id = id;
            Number = number;
            Name = name;
            AcademicEmail = academicEmail;
        }

    }
}
