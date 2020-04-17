using System;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var lalopez = new Escuela("Pedro Luis Villa", 1980);
            lalopez.SchoolType = SchoolTypes.Elemetary;
            lalopez.DoorBell();
            lalopez.City = "Medellín";
            lalopez.Country = "Colombia";
            Console.WriteLine(lalopez);
        }
    }
}
