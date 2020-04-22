using Core_Escuela.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core_Escuela.App
{
    public class SchoolEngine
    {
        public School School { get; set; }

        // Constructor
        public SchoolEngine()
        {
        }

        public void Initialize()
        {
            // Se instancia el objeto escuela, el cual tiene un atributo tipo arreglo
            School = new School("Pedro Luis Villa", 2000, SchoolTypes.Primary);

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
                int random = rnd.Next(2, 3);
                group.Students = GenerateStudents(random);
            }
        }

        private void LoadSubjects()
        {
            foreach (var group in School.Groups)
            {
                foreach (var student in group.Students)
                {
                    // Asignatura para cada estudiante del curso
                    List<Subject> SubjectList = new List<Subject>() {
                    new Subject { Name = "Math" },
                    new Subject { Name = "Biology" },
                    new Subject { Name = "Language" }};

                student.Subjects = SubjectList;
                }
            }
        }

        private void LoadEvaluations()
        {
            foreach (var group in School.Groups)
            {
                foreach (var student in group.Students)
                {
                    foreach (var subject in student.Subjects)
                    {
                        Random rand = new Random();

                        // Arreglos para generar nombres
                        string[] partial = { "Evaluation #" };
                        string[] number = { "1", "2", "3", "4", "5" };

                        // Producto cartesiano
                        var evaluationlList = from p in partial
                                              from n in number
                                              select new Evaluation() { Name = $"{p} {n}", Score = (rand.NextDouble() * 5).ToString("0.00") };

                        subject.Evaluations = evaluationlList.ToList();
                    }

                }
            }

        }

        private List<Student> GenerateStudents(int quantity)
        {
            // Arreglos para generar nombres
            string[] name = { "Alexandra", "Juan" };
            string[] lastName1 = { "Castrillón", "Aguirre" };
            string[] LastName2 = { "Valencia", "Mesa" };

            // Producto cartesiano
            var studentList = from n in name
                              from l1 in lastName1
                              from l2 in LastName2
                              select new Student(n) { Name = $"{n} {l1} {l2} " };

            return studentList.OrderBy((st) => st.UniqueId).Take(quantity).ToList();
        }
    }
}



