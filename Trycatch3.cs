using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Trycatch3
    {
        static void Main(string[] args)
        {
            FIRST:
            try
            {
                Console.WriteLine("Enter A value");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B value");
                int j = Convert.ToInt32(Console.ReadLine());
                int k = i / j;
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
            catch(StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            goto FIRST;
        }
    }
}
