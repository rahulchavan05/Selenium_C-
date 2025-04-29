using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Delegates
{
    public delegate void Calculator2(int x, int b);
    internal class MultipleDelegates
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
        public void MultipleDelegate()
        {
            Calculator cal = new Calculator(Add);

            cal = cal + Sub;

            cal(20, 10);
        }
    }
}
