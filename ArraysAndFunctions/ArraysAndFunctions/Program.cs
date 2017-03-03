using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndFunctions
{
    class Program
    {
        static void DisplayValues(string[] foo)
        {
            foreach (string e in foo)
            {
                Console.WriteLine("{0}", e);
            }

        }

        static void SortArray(string[] Names)
        {
            Console.WriteLine("\nNow display the array with standard Icollction sort method\n");
            Array.Sort(Names);
            DisplayValues(Names);
        }

        static void RevArray(string[] Names)
        {
           
            Array.Reverse(Names);
            DisplayValues(Names);
        }
        static void Main(string[] args)
        {
            string[] names = { "Brown", "Yellow", "Red", "White", "Purple", "Gray" };
            Console.WriteLine("Display the initial array");
            DisplayValues(names);

            // use sort method and display
            SortArray(names);
            Console.WriteLine();

            //Reverse the sorted array (this has been sorted previously and is in memory?) 

            Console.WriteLine("\nNow Reverse Array\n");
            RevArray(names);


            Console.ReadLine();

        }
    }
}
