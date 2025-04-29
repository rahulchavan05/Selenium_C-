using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Logicals.Programs
{
    internal class ValueTypeAndRefranceType
    {
        public void Value() { 
        //      #Value Types:
        //Data Storage:
        //Value types store the actual data directly in the variable's memory location.

        //Assignment:
        //When assigning a value type variable to another, the data is copied.

        //Example:
            int x = 5; int y = x; 
            //Here, y will contain a separate copy of the value 5, independent of x.

            //Types:
            //Include basic data types like int, bool, float, char, and user-defined types like structs.

            //      #Reference Types:
            //Data Storage:
            //Reference types store a reference (memory address) to the object's data, which is typically stored in the heap. 

            //Assignment:
            //When assigning a reference type variable to another, the reference is copied.

            //Example:
            string str1 = "Hello"; string str2 = str1; 
            //Both str1 and str2 now refer to the same object in memory.

            //Types:
            //Include classes, interfaces, delegates, arrays, and strings.

            //        #Key Differences:
            //Memory Allocation:
            //Value types are usually allocated on the stack, while reference types are typically allocated on the heap.

            //Copy Semantics:
            //Value types are copied by value, while reference types are copied by reference. 

            //Mutability:
            //Changes to a value type variable do not affect other variables that hold a copy of the original value. Changes to a reference type variable can affect any other variable that holds a reference to the same object. 

            //Garbage Collection:
            //Reference types require garbage collection to reclaim memory when they are no longer in use

        }
    }
}
