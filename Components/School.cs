using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela.Components
{
    public class School : EducationSystem
    {
        public int Fundation { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Group> Groups { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        // Constructor paradigma POO
        public School(string name, int fundation, SchoolTypes schooltype)
        {
            this.Name = name;
            this.Fundation = fundation;
            this.SchoolType = schooltype;
            this.Country = "Colombia";
            this.City = "Medellín";
        }
    }
}
