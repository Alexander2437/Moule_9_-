using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moule_9_Практикум_App
{
    internal class NewException : Exception
    {
        public NewException(string message) : base(message) {}
    }
}
