using System;
using System.Collections.Generic;
using static System.Console;

namespace Core_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Title("Stage IV");
            Printer.DrawLine(20);

            // Se instancia el objeto engine
            var engine = new SchoolEngine();
            engine.Initialize();

            // Método para recorrer el areglo
            PrintGroups(engine.School);
        }

        /// <summary>
        /// Comentar métodos
        /// </summary>
        /// <param name="school"></param>
        private static void PrintGroups(Escuela School)
        {
            // Evalúa que el arreglo no este vació para que no salga excepción en el ciclo for
            // El interrogarotio indica que no evalua el arreglo Groups si el objeto school es null
            if (School?.Groups != null)
            {
                foreach (Group Group in School.Groups)
                {
                    WriteLine(Group.Name + ", " + Group.UniqueId);
                }
            }
        }
    }
}
