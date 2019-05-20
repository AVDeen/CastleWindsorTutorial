using System;

namespace Demo
{
    public class CompositionRoot : ICompositionRoot
    {
        readonly IConsoleWriter consoleWriter;
        readonly ISingletonDemo singletonDemo;

        public CompositionRoot(IConsoleWriter consoleWriter, ISingletonDemo singletonDemo)
        {
            this.consoleWriter = consoleWriter;
            this.singletonDemo = singletonDemo;
            consoleWriter.LogMessage("Hello from the composition root Constructor!");
        }

        public void LogMessage(string message)
        {
            var msg = $"CompositionRoot.LogMessage: singletonDemo.ObjectId={singletonDemo.ObjectId}";
            consoleWriter.LogMessage(msg);
            consoleWriter.LogMessage(message);
        }
    }
}