// See https://aka.ms/new-console-template for more information

using System;
public class project2
{
    public static void Main()
    {
        Console.WriteLine("Project2: program to find the perfect numbers from n1 to n2");

        int n, i, sum;
       
        int startnum, endnum;

        Console.Write("1-Input the starting number: ");

        startnum = Convert.ToInt32(Console.ReadLine());

        Console.Write("2-Input the ending number: ");

        endnum = Convert.ToInt32(Console.ReadLine());

        Console.Write("3-The list of perfect numbers: ");

        for (n = startnum; n <= endnum; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        
    }
}
