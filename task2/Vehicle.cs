using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Vehicle
    {
            public string Brand { get; set; }
            public int Speed { get; set; }

            public void Start()
            {
                Console.WriteLine($"{Brand} is starting...");
            }

            public void Stop()
            {
                Console.WriteLine($"{Brand} is stopping...");
            }

            // Virtual so child classes can override it
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}");
                Console.WriteLine($"Speed: {Speed} km/h");
            }
    }
}
