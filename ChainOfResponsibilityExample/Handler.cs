using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public abstract class Handler
    {
        protected Handler NextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void HandleRequest(string request, string severity);
    }
}
