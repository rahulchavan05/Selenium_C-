using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class List
    {
        [Test]
        public void ListTest()
        {
            List <int> list = new List<int> { 1, 2, 3, 4 };

            Console.WriteLine(list[3]);

            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Add items
            ages["Alice"] = 30;
            ages["Bob"] = 25;

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddFirst(0);

            HashSet<string> set = new HashSet<string> { "apple", "banana" };
            set.Add("cherry");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("first");
            queue.Enqueue("second");
            string item = queue.Dequeue(); // "first"

            Stack<string> stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            string item2 = stack.Pop(); // "second"

        }
    }
}
