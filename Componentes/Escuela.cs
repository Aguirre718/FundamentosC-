using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    public class Escuela
    {
        // Encapsulamiento forma compacta
        public string Name { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }

        // Declaración de una lista genérica 
        public List<Group> Groups { get; set; }

        // Constructor por programación funcional; igualación por tuplas
        public Escuela(string name, int year) => (Name, Year) = (name, year);

        // Se pueden crear varios métodos con el mismo nombre siempre y cuando no tengan los mismo parámetros
        public Escuela(string name, int year, SchoolTypes school, string city, string country="") => 
                      (Name, Year, SchoolType, City, Country) = (name, year, school, city, country);

        // Sobre escribe la funcionalidad del método ToString: override
        public override string ToString()
        {
            return $"Name: \"{Name}\", School type: {SchoolType} \nYear: {Year}, Country: {Country}";
        }
    }
}
