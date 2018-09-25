using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Checked2
    {
        static void Main(string[] args)
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine("Int Maximum value is :"+val);
                Console.WriteLine(val + val);//now compiler showes the overflow exception
            }

        }
    }
}
/*
 * Int Maximum value is :2147483647

Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow.
   at ExceptionsPracties.Checked2.Main(String[] args) in F:\JAVA\C#\ExceptionsPracties\ExceptionsPracties\Checked2.cs:line 17
Press any key to continue . . .
*/
