using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class TryCatch1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter i value");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter j value");
                int j = Convert.ToInt32(Console.ReadLine());
                int k = i + j;
                Console.WriteLine("The K Value is :" + k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}
