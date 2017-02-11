using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i ;
            int m = 1;

            Console.Write("Insert a number: ");
            N = int.Parse(Console.ReadLine());

            while (N <= 0)
            {
                Console.Write("Please enter a number grater than zero: ");
                N = int.Parse(Console.ReadLine());
            }
                for (i = 1; i <= N; i++)
                {

                    m = m * i;
                }
                Console.Write("\nThe factorial of {0} is: {1}", N, m);
            
            Console.ReadKey();
        }
    }
}
