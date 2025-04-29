using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class SwapTwoNums
    {
        [Test]
        public void SwapNum()
        {
            string a = "5", b = "10";
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            //int temp = a;
            //a = b;
            //b = temp;

            //a = a + b;  // 15
            //b = a - b;  // 15-10 = 5
            //a = a - b;  // 15-5 = 10

            (a, b) = (b, a);        // this way posible to swap the string as well 


            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }
    }
}
