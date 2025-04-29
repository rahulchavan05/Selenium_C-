using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class ReverceArray
    {
        [Test]
        public void ArrLoop()
        {
            int[] arr = { 1, 2, 3, 9, 4, 5, 8 };
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                // Swap elements
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine(string.Join(", ", arr));  // Output: 5, 4, 3, 2, 1
        }

        [Test]
        public void Linq()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] reversedArr = arr.Reverse().ToArray();  // Creates a new reversed array

            Console.WriteLine(string.Join(", ", reversedArr));  // Output: 5, 4, 3, 2, 1
            Array.Sort(arr);   // o/p in seqence 
        }

        [Test]
        public void ArrayReverse()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr);  // Modifies the original array

            Console.WriteLine(string.Join(", ", arr));  // Output: 5, 4, 3, 2, 1

            
            Array.Sort(arr); // Output: 1, 2, 3, 4, 5 sort in sqence 
        }
    }
}
