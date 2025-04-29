using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.C_Sharph
{
    internal class EqualsString
    {
        // 2. Null Handling:
        // ==:
        // Can handle null values without throwing an error.If one of the operands is null, == returns false if the other is not null, and true if both are null.
        //.Equals() :
        // Calling.Equals() on a null value will throw a NullReferenceException.This is because the method is called on the object, and if the object is null, it cannot be accessed. 
 //                                                      ======================
        //============================================================================================\\
            //string str1 = "Hello";
            //string str2 = new string("Hello");
            //string str3 = str2;

            //Console.WriteLine(str1 == str2); // False (different objects)
            //Console.WriteLine(str2 == str3); // True (same object)
            //Console.WriteLine(str1.Equals(str2)); // True (content is the same)
            //Console.WriteLine(str2.Equals(str3)); // True (content is the same)

    }
}
