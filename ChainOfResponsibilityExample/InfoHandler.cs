using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class InfoHandler : Handler
    {
        public override void HandleRequest(string request, string severity)
        {
            if (severity == "Info")
            {
                Console.WriteLine($"[INFO]: {request}");
            }
            else
            {
                NextHandler?.HandleRequest(request, severity);
            }
        }
    }
}
