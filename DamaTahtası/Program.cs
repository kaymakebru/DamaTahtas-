using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaTahtası
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                        Console.Write(" *");
                    else
                        Console.Write("* ");
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
        
    }
}
