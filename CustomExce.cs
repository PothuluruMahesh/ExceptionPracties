using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    public class CustomExce1 : Exception
    {
        public CustomExce1(String message): base(message)
        {
            //message = "NEWEXCEPTIONS";
        }
    }
    public class CustomExce
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new CustomExce1("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (CustomExce1 e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
        }
    }
}
