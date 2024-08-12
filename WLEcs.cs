using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_12_Exceptions
{
    internal class WrongLoginException : Exception
    {
        private string exLogin {  get; set; } = string.Empty;
        internal WrongLoginException() { }
        internal WrongLoginException(string exLogin, string message) : base(message) 
        {
            this.exLogin = exLogin;
        }
    }
}
