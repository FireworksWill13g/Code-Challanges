using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfZerosInTail
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number :");
        int num = int.Parse(Console.ReadLine());
        int Count;
        int len;
        //{Write your Code Here  
        len = num.ToString().Length;
        string numbs = num.ToString();


        Console.WriteLine("Number of digits in entered number:" + len);
        Console.WriteLine("the string: " + numbs);

        for (int i = len; i > 0; i--) ;
        if (char[i] == 0)
            Count++;
        if (char[i - 1] == 0)
            Count++;





        //}  
        Console.WriteLine("number of zeros in the tail is :");
        Console.WriteLine(Count);
    }

}
