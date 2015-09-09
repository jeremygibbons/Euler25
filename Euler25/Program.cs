using System;

namespace Euler25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            while (FiboLengthN(i) < 1000)
                i++;
            Console.WriteLine(i);
            Console.ReadLine();

        }

        //Length of fibonacci number of rank n, per the Binet formula
        static int FiboLengthN(int n)
        {
            double phi = (1.0 + Math.Sqrt(5)) / 2;
            return (int)(n * Math.Log10(phi) - Math.Log10(5.0) / 2 + 1);
        }
    }
}
