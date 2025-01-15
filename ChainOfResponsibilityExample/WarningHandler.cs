using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class WarningHandler : Handler
    {
        public override void HandleRequest(string request, string severity)
        {
            if (severity == "Warning")
            {
                Console.WriteLine($"[WARNING]: {request}");
            }
            else
            {
                NextHandler?.HandleRequest(request, severity);
            }
        }
    }
}
