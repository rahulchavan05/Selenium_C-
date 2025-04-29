using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class Print1to10Then10to1
    {
        [Test]
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 19; i++)
            {
                int number = i <= 10 ? i : 20 - i;  // Print 1 to 10, then 10 to 1
                Console.Write(number + " ");
            }
        }
    }
}
