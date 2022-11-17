using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            SQRT(n);
        }

        private static void SQRT(int n)
        {
            Console.WriteLine(Math.Sqrt(n));
        }
    }//endclass
}