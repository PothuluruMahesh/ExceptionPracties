using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Unchecked1
    {
        static void Main(string[] args)
        {
            
            {

                const int val = int.MaxValue;
                Console.WriteLine("Int Maximum value is :" + val);
               // Console.WriteLine(val + val);//if u want cheng the constant value it rise an compile time error
            }

        }
    }
}
