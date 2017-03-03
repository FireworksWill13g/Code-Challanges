using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingMachine
{




    /* Counting Machine - Purpose
     * Write a program that gets an integer from the user. Count from 0 to that number or its absolute value. Use a for loop to do it.


        Count to:8
        0 1 2 3 4 5 6 7 8
 

        Count to:-3
        0 1 2 3
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Count to:");
            int n = int.Parse(Console.ReadLine());
            //write your code here
            if (n < 0)
            {
                n = ~n + 1;
            }
            for (int x = 0; x <= n; x++)
            {
                Console.Write(x);
            }

        }
    }
}
