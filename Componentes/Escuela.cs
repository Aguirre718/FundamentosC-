using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    class Escuela
    {
        // Encapsulamiento manera 1
        private string name;

        public string Name
        {
            get { return "Copia: " + name; }
            set { name = value.ToUpper();  }
        }

        // Encapsulamiento maera 2
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        /* Construcción de constructor en el paradigma de POO
        public Escuela(string name, int year)
        {
            this.name = name;
            this.year = year;
        }*/

        // Constructor por programación funcional; igualación por tuplas
        public Escuela(string name, int year) => (Name, Year) = (name, year);

        public void beep()
        {
            Console.Beep(1000, 2000);
            Console.WriteLine("¡Already rang!");
        }
    }
}
