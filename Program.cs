using System;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var lalopez = new Escuela("Pedro Luis Villa", 1980, SchoolTypes.Primary, "Medellín");
            lalopez.DoorBell();
            Console.WriteLine(lalopez);
        }
    }
}
