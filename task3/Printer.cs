using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method 2: Print an integer number
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // Method 3: Print a message multiple times
        public void Print(string message, int count)
        {
            Console.WriteLine("Repeated Message:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {message}");
            }
        }
    }
}
