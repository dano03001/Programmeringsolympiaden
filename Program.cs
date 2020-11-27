using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 13;
            int a = 7;

            Console.Write("Äpplen ? " );
            int antala = int.Parse(Console.ReadLine());
            Console.Write("Päron ? ");
            int antalp = int.Parse(Console.ReadLine());

            int asum = antala * a;
            int psum = antalp * p;

            if (asum > psum)
            {
                Console.WriteLine("Svar: Axel");
            }
            else if (asum < psum)
            {
                Console.WriteLine("Svar: Petra");
            }
            else
                Console.WriteLine("Svar: lika");
        }
    }
}
