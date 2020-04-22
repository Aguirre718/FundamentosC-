using Core_Escuela.App;
using Core_Escuela.Components;
using Core_Escuela.Utilitarian;
using System;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
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

        private static void PrintGroups(School School)
        {
            // Evalua que tanto School como Groups no sea null
            if (School?.Groups != null)
            {
                foreach (Group group in School.Groups)
                {
                    WriteLine("\n   Group: " + group.Name + " UniqueId: " + group.UniqueId);
                    foreach (Student student in group.Students)
                    {
                        WriteLine("\nStudent name: " + student.Name + " -> UniqueId: " + group.UniqueId);
                        foreach (Subject subject in student.Subjects)
                        {
                            // Cuenta cuantos elementos hay en la colección 
                            int len = (subject.Evaluations).Count;
                            WriteLine("\n Subject: " + subject.Name);
                            float score, sum = 0;
                            foreach (Evaluation evaluation in subject.Evaluations)
                            {
                                score = Convert.ToSingle(evaluation.Score);
                                sum = score + sum;
                                WriteLine("  " + evaluation.Name + ": " + evaluation.Score);
                            }
                            WriteLine($"\n  Average: {(sum / len)}");
                        }
                    }
                }
            }
        }
    }
}
