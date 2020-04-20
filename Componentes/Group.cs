using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    class Group
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public SchoolTime Time { get; set; }

        // Constructor en Programación Funcional
        public Group(string name) => (UniqueId, Name) = (Guid.NewGuid().ToString(), name);
    }
}
