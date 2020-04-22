using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela.Components
{
    public class Student : EducationSystem
    {
        public List<Subject> Subjects { get; set; }

        // Constructor
        public Student(string name) => Name = name;
    }
}
