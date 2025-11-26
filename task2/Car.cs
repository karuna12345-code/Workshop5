using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();   // Reusing base class method
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
