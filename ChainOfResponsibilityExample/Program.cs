using System;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler infoHandler = new InfoHandler();
            Handler warningHandler = new WarningHandler();
            Handler errorHandler = new ErrorHandler();

            infoHandler.SetNextHandler(warningHandler);
            warningHandler.SetNextHandler(errorHandler);

            infoHandler.HandleRequest("System initialized", "Info");
            infoHandler.HandleRequest("Disk space low", "Warning");
            infoHandler.HandleRequest("System crash", "Error");
            infoHandler.HandleRequest("Unknown issue", "Critical");
        }
    }
}
