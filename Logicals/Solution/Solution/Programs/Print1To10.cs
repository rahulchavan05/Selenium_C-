using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class Print1To10
    {
        //public static void Main(String[] args)
        //{

        //    printNum();
        //    Console.ReadLine();
        //}

        static int i = 1;
        [Test]
        [Category("Regration")]
        public static void printNum()
        {

            Console.WriteLine(i);
            i++;
            loop();
        }

        public static void loop()
        {
            if (i <= 10)
            {
                printNum();
            }
        }
    }
}
