using System;
public class addition
{
    public static void Main(string[] args)
    {
        ///{Write your logic here
        for (int i = 1; i <= 9; i++)
        {
            for(int j=0; j<=9;j++)
            {
                Console.WriteLine("{0}{1}. {0}+{1} = {2}", i,j, i+j);
            }   
        }
        ///}
        Console.ReadLine();
    }
}