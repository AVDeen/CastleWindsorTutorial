using System;

namespace Demo
{
    public class ConsoleWriter : IConsoleWriter
    {
        readonly ISingletonDemo singletonDemo;

        public ConsoleWriter(ISingletonDemo singletonDemo)
        {
            this.singletonDemo = singletonDemo;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("ConsoleWriter.LogMessage: singletonDemo.ObjectId={0}",
                               singletonDemo.ObjectId);
            Console.WriteLine(message);
        }
    }
}