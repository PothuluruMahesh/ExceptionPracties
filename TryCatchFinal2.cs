using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class TryCatchFinal2
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter A value");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B value");
                int j = Convert.ToInt32(Console.ReadLine());
                if(i==0)
                {
                    return;//here it turminate main method but after exicute finally block only that is the power of finally block.
                }
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
            catch(Exception ex)
            {
                Console.WriteLine("Exception Block"+ex);
            }
            finally//exception rice are not it should be exicute.
            {
                Console.WriteLine("It is Mandetory Block");
                //it is moslty used to close the connection(ex:db,file io)
            }
        }
    }
}
