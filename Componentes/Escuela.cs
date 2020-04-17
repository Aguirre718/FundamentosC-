using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    class Escuela
    {
        /*// Encapsulamiento manera 1
        private string name;

        public string Name
        {
            get { return "Copia: " + name; }
            set { name = value.ToUpper();  }
        }*/

        // Encapsulamiento maera 2
        public string Name { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }

        /* Construcción de constructor en el paradigma de POO
        public Escuela(string name, int year)
        {
            this.name = name;
            this.year = year;
        }*/

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

        public void DoorBell()
        {
            Console.Beep(1000, 2000);
            Console.WriteLine("¡Already rang!");
        }
    }
}
