using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class CustomException1
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserDefinedAndException("You Are Not Eligible For VOtE");
            }
            catch(UserDefinedAndException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class UserDefinedAndException : Exception
    {
        public UserDefinedAndException() : base()
        {

        }
        public UserDefinedAndException(string message) : base(message)
        {

        }
    }
}
