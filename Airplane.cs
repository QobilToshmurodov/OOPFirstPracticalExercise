using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstPracticalExercise
{
    public class Airplane :Transport
    {
        public Airplane() { }

        public int Altitude {  get; set; }
        public void TakeOff()
        {
            if (Altitude > 0)
                Console.WriteLine("Samalyot uchmoqda");
            else Console.WriteLine("Samalyot yerda");
        
        }
    }
}
