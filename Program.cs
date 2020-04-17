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
            Console.WriteLine("-----------------------------------------------------------------");

            var group1 = new Group("101");
            var group2 = new Group("201");
            var group3 = new Group("301");
            Console.WriteLine(group1.Name + ", " + group1.UniqueId);
            Console.WriteLine($"{group2.Name}, {group2.UniqueId}");
            Console.WriteLine(group3);
        }
    }
}
