using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Checked1
    {
        static void Main(string[] args)
        {
            int val = int.MaxValue;
            Console.WriteLine(val + val);//it rise OverflowException and it doesn't show any error or exception
        }//by using checked keyword we can overcome it.
    }
}
/*
 * -2
Press any key to continue . . .
*/
