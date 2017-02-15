using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int i;
            int a;

            for (i = 0; i < N; i++)
            {
                for (a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
