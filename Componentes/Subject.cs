using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    public class Subject
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        public Subject() => (UniqueId) = Guid.NewGuid().ToString();
    }
}
