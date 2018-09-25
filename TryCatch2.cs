using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class TryCatch2
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 50;
                int j = 0;
                int k = i / j;
                Console.WriteLine("The K Value is :" + k);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Super class is Exception"+ex);
            }
        }
    }
}
