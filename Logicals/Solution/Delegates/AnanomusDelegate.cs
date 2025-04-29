using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Delegates
{
    internal class AnanomusDelegate
    {
        public void Add(int a, int b)
        {

            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {

            Console.WriteLine(a - b);
        }

        [Test]
        public void AnanomusDelegate1()
        {
            Calculator cal = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            cal(12, 22);
        }
    }
}
