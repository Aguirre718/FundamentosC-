using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    public class SchoolEngine
    {
        public Escuela School { get; set; }

        public SchoolEngine()
        { 
        }

        public void Initialize()
        {
            // Se instancia el objeto escuela, el cual tiene un atributo tipo arreglo
            School = new Escuela("Pedro Luis Villa", 2000, SchoolTypes.Primary, city: "Medellín");

            // Adición de elementos a la lista
            School.Groups = new List<Group>()
            {
                new Group("101") { Time = SchoolTime.Morning },
                new Group("201") { Time = SchoolTime.Morning },
                new Group("301") { Time = SchoolTime.Morning },
                new Group("401") { Time = SchoolTime.Morning },
                new Group("501") { Time = SchoolTime.Morning }
            };
        }
    }
}


