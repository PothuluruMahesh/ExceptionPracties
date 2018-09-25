using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class CostumeEXE : Exception
    {
        static void Main(string[] args)
        {
            int i = 50;
            int j = 0;
            if(j==0)
            {
                throw new DivideByZeroException("Zero not divide");
            }
            int k = i / j;
            Console.WriteLine("The K Value is :" + k);
        }
    }
}
