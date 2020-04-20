using System;
using System.Collections.Generic;
using static System.Console;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     School Stage II    ");
            // Se instancia el objeto escuela, el cual tiene un atributo tipo arreglo
            var school = new Escuela("Pedro Luis Villa", 2000, SchoolTypes.Primary, city: "Medellín");

            school.Groups = new List<Group>()
            {
                new Group("101") { Time = SchoolTime.Morning },
                new Group("201") { Time = SchoolTime.Morning },
                new Group("301") { Time = SchoolTime.Morning }
            };

            // Agregar nuevos elementos a la lista
            school.Groups.Add(new Group("102") { Time = SchoolTime.Afternoon });
            school.Groups.Add(new Group("202") { Time = SchoolTime.Afternoon });

            // Definición de otra colección 
            var othCollect = new List<Group>()
            {
                new Group("401") { Time = SchoolTime.Morning },
                new Group("501") { Time = SchoolTime.Morning },
                new Group("502") { Time = SchoolTime.Afternoon }
            };

            // Agrega otra colección a la colección que ya tenía
            school.Groups.AddRange(othCollect);

            // Delegado para buscar un elemento en una lista, cuando coincide
            // un nombre retorna True y lo elimina, de lo contario retorna 
            // False y no lo elimina
            school.Groups.RemoveAll(delegate (Group gro)
            {
                return gro.Name == "301";
            });

            // Elimina elementos de la lista por medio de la expresón Lambda
            // Igual es un delegado pero más compacto
            school.Groups.RemoveAll((gro) => gro.Name == "501");
            
            // Evalúa que el arreglo no este vació para que no salga excepción en el ciclo for
            // El interrogarotio indica que no evalua el arreglo Groups si el objeto school es null
            if (school?.Groups == null)
            {
                return;
            }else
            {
                // Método para recorrer el areglo
                PrintGroups(school);
            }
        }

        /// <summary>
        /// Comentar métodos
        /// </summary>
        /// <param name="school"></param>
        private static void PrintGroups(Escuela school)
        {
            foreach (Group Group in school.Groups)
            {
                WriteLine(Group.Name + ", " + Group.UniqueId);
            }
        }
    }
}
