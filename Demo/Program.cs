using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            // Register
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>().LifestyleTransient());

            // Resolve
            var root = container.Resolve<ICompositionRoot>();
            var test = container.Resolve<ISingletonDemo>();

            // Use
            root.LogMessage("Hello from the resolved Composition Root!");
        }
    }
}
