using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Unchecked2
    {
        static void Main(string[] args)
        {
            unchecked
            {
                const int val = int.MaxValue;
                Console.WriteLine("Int Maximum value is :" + val);
                Console.WriteLine(val + val);
               

            }
        }
    }
}



