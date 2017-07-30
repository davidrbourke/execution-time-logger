using System;
using  Microsoft.Extensions.DependencyInjection;

namespace ExecutionTimeLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serviceProvider = new ServiceCollection();
                //.AddSingleton<IFooService, FooService>()
                //.BuildServiceProvider();

            var eventTimer = new EventTimer(new FileLogger());
            eventTimer.Start("a", "b");
            eventTimer.Stop();
        }
    }
}
