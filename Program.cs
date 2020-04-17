using System;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var lalopez = new Escuela("Pedro Luis Villa", 1980);
            lalopez.beep();
            Console.WriteLine(lalopez.Name);
        }
    }
}
