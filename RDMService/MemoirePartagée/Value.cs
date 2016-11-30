using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDMService
{
    internal class Value
    {
        internal string Password { get; private set; }

        internal object Data { get; set; }

        internal Value(string password)
        {
            Password = password;
        }
    }
}