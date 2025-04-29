using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    class Boxing
    {
        public void Show()
        {
            int num = 100;                // Value type
            object obj = num;             // ✅ Boxing: int -> object

            Console.WriteLine("Boxed value: " + obj);

            int unboxedNum = (int)obj;    // ✅ Unboxing: object -> int
            Console.WriteLine("Unboxed value: " + unboxedNum);
        }
    }
}
