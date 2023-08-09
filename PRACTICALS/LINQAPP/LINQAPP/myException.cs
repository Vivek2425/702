using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAPP
{
    class myException : Exception
    {
        public myException()
        {
                
        }
        public myException(string message) : base(message)
        {
        }

        public myException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
