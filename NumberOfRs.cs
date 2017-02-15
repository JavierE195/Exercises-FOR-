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
            string b;
            int c = 0;


            b = Console.ReadLine();
            for (int i = 0; i < b.Length; i++)
            {
                string r = b[i].ToString();
                if (r == "r" || r == "R")
                {
                    c++;
                }
                 
            }
            Console.WriteLine(c);
            
            Console.ReadKey();
        }
    }
}
