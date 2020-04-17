using System;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     School Stage II    ");
            var arrayGroups = new Group[3];
            arrayGroups[0] = new Group("101");
            arrayGroups[1] = new Group("201");
            arrayGroups[2] = new Group("301");

            // Método para recorrer el areglo
            PrintGroups(arrayGroups);
        }

        private static void PrintGroups(Group[] arrayGroups)
        {
            for (int i = 0; i < arrayGroups.Length; i++)
            {
                Console.WriteLine(arrayGroups[i].Name + ", " + arrayGroups[i].UniqueId);
            }
        }
    }
}
