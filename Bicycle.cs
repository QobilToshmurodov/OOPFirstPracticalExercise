using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPFirstPracticalExercise
{
    public class Bicycle:Transport
    {
        public Bicycle() { }

        public bool HasBell { get; set; }

        public void RingBell()
        {
            if (HasBell)
                Console.WriteLine($"{Name} qo'ng'iroq chalmoqda: Tring Tring!");
            else
                Console.WriteLine($"{Name} da qo'ng'iroq yo'q.");
        }
    }
}
