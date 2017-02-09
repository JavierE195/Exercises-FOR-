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

            for (i = 0; m < (N * 9); i++)
            {
                m = i * 9;
                Console.Write("\n{0}", m);
            }
            Console.ReadKey();
        }
    }
}
