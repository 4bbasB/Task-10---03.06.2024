using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10___03._06._2024.Helpers
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message) { }
    }
}
