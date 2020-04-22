using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela.Components
{
    public class Subject : EducationSystem
    {
        public List<Evaluation> Evaluations { get; set; }

        public Subject()
        {
        }
    }
}
