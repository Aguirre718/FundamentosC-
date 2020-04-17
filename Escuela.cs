using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    class Escuela
    {
        public string name;
        public string address;
        public string year;
        public string ceo;

        public void beep()
        {
            Console.Beep(1000, 2000);
            Console.WriteLine("¡Already rang!");
        }
    }
}
