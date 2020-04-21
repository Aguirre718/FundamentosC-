using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Escuela
{
    public class Evaluations
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public string Score { get; set; }

        // Constructor
        public Evaluations() => (UniqueId) = Guid.NewGuid().ToString();
    }
}

