// See https://aka.ms/new-console-template for more information
using System;
public class project1
{
    public static void Main()
    {
        Console.WriteLine("Project1: program to write the prime numbers from n1 to n2.");

        int num, satrtnum, endnum, ctr, i;

        Console.Write("1-Input starting number: ");

        satrtnum = Convert.ToInt32(Console.ReadLine());

        Console.Write("2-Input ending number: ");

        endnum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("3-The list of the prime numbers between {0} and {1} are : ", satrtnum, endnum);

        for (num = satrtnum; num <= endnum; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
    }
}
        

