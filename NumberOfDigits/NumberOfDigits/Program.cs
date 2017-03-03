using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDigits
{

    /*
     * Write a program that counts number of digits within a number given by the user.

        Enter a number:1234323
        The number of digits is 7
     */

    class Program
    {
        static void Main(string[] args)
        {


            int num, count;
            Console.Write("Enter a number:");
            num = int.Parse(Console.ReadLine());
            ///{Write your logic here
            count = 0;
            while (num != 0)
            {
                // Divide the number by ten, since this in an int. decimals are turnicated 
                // repeat division until the number is 0 or all decimals (which in an int = 0 as deciamals are turnicated) 
                num /= 10;  // this is equivalent to num = num/10 
                ++count;
            }





            ///}
            Console.WriteLine("The number of digits is {0}", count);

        }
    }
}
