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
            int i = 0;

            Console.Write("Insert a number: ");
            N = int.Parse(Console.ReadLine());

            for (i = 0; i <= N; i ++)
            {
                Console.Write("\n{0}", i);
            }
            Console.Write("\nTotal of numbers (Including zero): {0}", N + 1);
            Console.ReadKey();
        }
    }
}
