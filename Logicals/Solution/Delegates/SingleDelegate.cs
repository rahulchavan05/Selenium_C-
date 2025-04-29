using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Delegates
{
    public delegate void Calculator(int x, int y);
    internal class SingleDelegate
    {

        // Event is depents on delegated 
        // Even is a wrapper over the delegated to improve the security 
        public void Add(int a, int b) {

            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {

            Console.WriteLine(a - b);
        }

        [Test]
        public void Delegate() 
        {
            Calculator cal = new Calculator(Add);

            cal(10, 20);
        }
    }
}
