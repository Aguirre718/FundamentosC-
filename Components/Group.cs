using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela.Components
{
    public class Group : EducationSystem
    {
        public SchoolTime Time { get; set; }
        public List<Student> Students { get; set; }

        // Contructor
        public Group(string name) => Name = name;
    }
}
