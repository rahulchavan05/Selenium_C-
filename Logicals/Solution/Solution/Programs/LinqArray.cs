using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Logicals.Programs
{
    internal class LinqArray
    {
        [Test]
        [Retry(3)]
        public void Linq()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers: " + string.Join(", ", arr.Where(x => x % 2 == 0)));
            Console.WriteLine("Odd numbers: " + string.Join(", ", arr.Where(x => x % 2 != 0)));
        }
    }
}
