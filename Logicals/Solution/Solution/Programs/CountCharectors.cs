using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    internal class CountCharectors
    {
        [Test]
        public void count()
        {
            
            string input = "Hello Word";

            Hashtable charCount = new Hashtable();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c] = (int)charCount[c] + 1;
                else
                    charCount[c] = 1;
            }

            foreach (DictionaryEntry pair in charCount)
            {
                Console.WriteLine($"'{pair.Key}' : {pair.Value}");
            }
        }

        [Test]
        static void count2()
        {
            string name = "aabbcdd"; // Example input
            HashSet<char> printedChars = new HashSet<char>(); // To track processed characters

            for (int i = 0; i < name.Length; i++)
            {
                if (!printedChars.Contains(name[i])) // Print only if not printed before
                {
                    int temp = 0;
                    for (int j = 0; j < name.Length; j++)
                    {
                        if (name[i] == name[j])
                        {
                            temp++;
                        }
                    }
                    Console.WriteLine(name[i] + " = " + temp);
                    printedChars.Add(name[i]); // Mark character as processed
                }
            }
        }

        [Test]
        static void count3()
        {
            string name = "aabbcdd"; // Example input
            char[] ch= name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (!ch.Contains(name[i])) // Print only if not printed before
                {
                    int temp = 0;
                    for (int j = 0; j < name.Length; j++)
                    {
                        if (name[i] == name[j])
                        {
                            temp++;
                        }
                    }
                    Console.WriteLine(name[i] + " = " + temp);
                    //ch = name[i];
                }
            }
        }
    }
    
}
