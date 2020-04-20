using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    public class Student
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        // Constructor
        public Student(string name) => (UniqueId, Name) = (Guid.NewGuid().ToString(), name);
    }
}
