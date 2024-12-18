using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstPracticalExercise
{
    public class Transport
    {
        public Transport() 
        {
        
        }
        public string Name { get; set; }
        public int Speed { get; set; }
        public void DisplayInfo()
        {

            Console.WriteLine($"Transport nomi: {Name}, Tezligi: {Speed} km/soat");
        }
    }
}
