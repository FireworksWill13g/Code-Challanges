using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 Collatz Sequence

Take any natural number n.
If n is even, divide it by 2 to get n / 2.
If n is odd, multiply it by 3 and add 1 to get 3n + 1.
Repeat the process indefinitely.
In 1937, Lothar Collatz proposed that no matter what number you begin with, the sequence eventually 
reaches 1. This is widely believed to be true, but has never been formally proved.
Write a program that inputs a number from the user, and then displays the Collatz Sequence starting 
from that number. Stop when you reach 1. It should also count the steps that it takes to get to 1.

 */


namespace CollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting number:");
            int n = int.Parse(Console.ReadLine());
            int steps = 0;
            //write your code here

            // Do we need to worry about negative numbers? 
            // If so need to write conditional to handle and remember to add sign to numbers.

            // if ( n < 0) 
            // {
            //   n = ~n + 1;
            // }

            // then convert numbers to negatives 
            if (n < 0)
            {
                Console.WriteLine("Only positive numbers");
            }

            // consider another method with WHILE Loop or Do While
            for (steps = 0; n > 1; steps++)
            {
                Console.Write(" " + n);
        

                if (n % 2 == 0) // If even then divide by 2
                {
                    n /= 2;
                   // Console.Write(" " + n);
                }

                else // if not even, then must be odd multiply by 3 and add 1
                {
                    n = (3 * n) + 1;
                    // Console.Write(" " + n);
                }
              if ( n == 1)
                {
                    Console.Write(" " + n);
                    ++steps;
                    break;
                }
            }

            Console.WriteLine();



            //
            Console.WriteLine("Terminated after:{0} steps", steps);
            Console.ReadLine();

        }
    }
}
