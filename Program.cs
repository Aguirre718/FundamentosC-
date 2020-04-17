using System;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.name = "Pedro Luis Villa";
            miEscuela.address = "Crr 37 # 66D - 18";
            miEscuela.beep();
            //Console.WriteLine("Hello World!");
        }
    }
}
