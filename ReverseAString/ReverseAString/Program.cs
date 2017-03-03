using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string or sentence or list of numbers");
            string userString = Console.ReadLine();

            char[] Usting = userString.ToArray();

            for (int i = Usting.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", Usting[i]);
            }

            // shorter method that takes less lines of code
            Console.WriteLine("\n shorter method of Array.Reverse");
            Array.Reverse(Usting);
            Console.WriteLine(Usting);  

            Console.WriteLine("\n Did it Work?");
            Console.ReadLine();
        }
    }
}
