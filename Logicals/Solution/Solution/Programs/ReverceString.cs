using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    public class ReverceString
    {
        [Test]
        public void reverce() 
        { 

            string str = "Hello World";
            string rev = new string(str.Reverse().ToArray());

            Console.WriteLine(rev);
            Console.WriteLine(str);
            Console.ReadLine();
        
        }

        [Test]
        public void ReverseWithoutBuiltIn()
        {
            string str = "Hello";

            char[] charArray = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                charArray[i] = str[j];
            }

            string reversed = new string(charArray); // Corrected instantiation of string
            Console.WriteLine(reversed);
        }

        
        public void Reverse2()
        {

            string str = "hello";

            char[] c = new char[str.Length];

            for(int i =0, j=str.Length - 1; i < str.Length; i++, j--)
            {
                c[i] = str[j] ;
            }

            string reverse = new string(c);
            Console.WriteLine(reverse);
            Console.WriteLine(str[2]);

        }

        public void Reverse3()
        {
            string str = "Rahul";

            char[] c = new char[str.Length];

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                c[i] = str[j];
            }

            string reverse = new string(c);
            Console.WriteLine(reverse);
            
        }

        [Test]
        public void Revercestring()
        {
            string name = "Rahul";

            string reverce = "";
            Console.WriteLine(name.Length);

            for(int i = name.Length-1; i >= 0; i-- )
            {
                reverce = reverce + name[i];
            }

            Console.WriteLine(reverce);
        }



        [Test]
        public static void ReverceSentence()
        {
            string name = "Rahul chavan";
            string[] strAr = name.Split(' ');


            for(int i = 0; i < strAr.Length;  i++)
            {
                char[] cha = strAr[i].ToCharArray();

                for (int j = 0, k = cha.Length-1; j < k; j++, k--)
                {
                    char temp = cha[j];
                    cha[j] = cha[k];
                    cha[k] = temp;
                }

                strAr[i] = new string(cha);

            }

            Console.WriteLine(string.Join(" ", strAr));
        }


    }
}
