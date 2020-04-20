using System;
using static System.Console;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     School Stage II    ");
            // Se instancia el objeto escuela, el cual tiene un atributo tipo arreglo
            var school = new Escuela("Pedro Luis Villa", 2000, SchoolTypes.Primary, city: "Medellín")
            {
                Groups = new Group[]
                {
                    new Group("101"),
                    new Group("201"),
                    new Group("301")
                }
            };

            // Evalúa que el arreglo no este vació para que no salga excepción en el ciclo for
            // El interrogarotio indica que no evalua Groups si schoo es null
            if (school?.Groups == null)
            {
                return;
            }else
            {
                // Método para recorrer el areglo
                PrintGroups(school.Groups);
            }
        }

        private static void PrintGroups(Group[] arrayGroups)
        {
            for (int i = 0; i < arrayGroups.Length; i++)
            {
                WriteLine(arrayGroups[i].Name + ", " + arrayGroups[i].UniqueId);
            }
        }
    }
}
