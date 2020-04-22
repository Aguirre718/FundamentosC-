using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela.Components
{
    public class EducationSystem
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        // Constructor por paradigma Funcional, igualación por Tuplas.
        public EducationSystem() => UniqueId = Guid.NewGuid().ToString();
    }
}
