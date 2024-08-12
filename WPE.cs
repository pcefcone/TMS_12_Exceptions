using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_12_Exceptions
{
    internal class WrongPasswordException : Exception
    {
        private string exPassword {  get; set; } = string.Empty;
        internal WrongPasswordException() { }
        internal WrongPasswordException(string Password, string message) : base(message)
        {
            this.exPassword = Password;
        }
    }
}
