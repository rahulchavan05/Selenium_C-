using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Logicals.Programs
{
    internal class PrintStar
    {
        [Test]
        public void Printstar()
        {
            int temp = 5;

            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }


        [Test]
        public void Printstar2()
        {
            int temp = 5;

            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp - i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j <(2 * i - 1); j ++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }


        }
    }
}
