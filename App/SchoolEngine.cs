using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_Escuela
{
    public class SchoolEngine
    {
        public Escuela School { get; set; }

        // Constructor
        public SchoolEngine()
        { 
        }

        public void Initialize()
        {
            // Se instancia el objeto escuela, el cual tiene un atributo tipo arreglo
            School = new Escuela("Pedro Luis Villa", 2000, SchoolTypes.Primary, city: "Medellín");

            LoadGroups();
            LoadSubjects();
            
            LoadEvaluations();
        }

        private void LoadGroups()
        {
            // Adición de elementos a la lista
            School.Groups = new List<Group>()
            {
                new Group("101") { Time = SchoolTime.Morning },
                new Group("201") { Time = SchoolTime.Morning }
                /*new Group("301") { Time = SchoolTime.Morning },
                new Group("401") { Time = SchoolTime.Morning },
                new Group("501") { Time = SchoolTime.Morning }*/
            };

            // Generar un número aleatorio para la contidad de estudiantes por grupo
            Random rnd = new Random();
           
            foreach (var group in School.Groups)
            {
                int random = rnd.Next(1, 2);
                group.Student = GenerateStudents(random);
            }
        }

        private void LoadEvaluations()
        {
            foreach (var group in School.Groups)
            {
                foreach (var subject in group.Subject )
                {
                    foreach (var student in group.Student)
                    {
                        Random rand = new Random();

                        // Arreglos para generar nombres
                        string[] partial = { "Partial #" };
                        string[] number = { "1", "2" };

                        // Producto cartesiano
                        var partialList = from p in partial
                                          from n in number
                                          select new Evaluations() { Name = $"{p} {n}", Score = (rand.NextDouble() * 5).ToString("0.00") };

                        student.Evaluation = partialList.ToList();
                    }

                }
            }

        }

        private void LoadSubjects()
        {
            foreach(var group in School.Groups)
            {
                List<Subject> SubjectList = new List<Subject>() { 
                    new Subject{ Name = "Math" },
                    new Subject{ Name = "Biology" }
                    //new Subject{ Name = "Language" }
                } ;
                group.Subject = SubjectList;
            }
        }

        private List<Student> GenerateStudents(int quantity)
        {
            // Arreglos para generar nombres
            string[] name = { "Alexandra", "Juan"};
            string[] lastName1 = { "Castrillón", "Aguirre" };
            string[] LastName2 = { "Valencia", "Mesa" };

            // Producto cartesiano
            var studentList = from n in name
                              from l1 in lastName1
                              from l2 in LastName2
                              select new Student(n) { Name = $"{n} {l1} {l2} " };

            return studentList.OrderBy((st) => st.UniqueId).Take(quantity).ToList();
        }

        private List<Evaluations> GeneratePartial()
        {
            Random rand = new Random();

            // Arreglos para generar nombres
            string[] partial = { "Partial #" };
            string[] number = { "1", "2" };

            // Producto cartesiano
            var partialList = from p in partial
                              from n in number
                              select new Evaluations() { Name = $"{p} {n}", Score = (rand.NextDouble() * 5).ToString("0.00") };

            return partialList.ToList();

           // List<Evaluations> EvaluationList = new List<Evaluations>() {
             //       new Evaluations { Name = "Partial # 1", Score = score },
              //      new Evaluations { Name = "Partial # 2", Score = score}
                //};
        }
    }
}


