using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class ErrorHandler : Handler
    {
        public override void HandleRequest(string request, string severity)
        {
            if (severity == "Error")
            {
                Console.WriteLine($"[ERROR]: {request}");
            }
            else
            {
                Console.WriteLine($"Unhandled request: {request} with severity {severity}");
            }
        }
    }
}
