using NetCoreConsoleApp.Interfaces;
using System;

namespace NetCoreConsoleApp.Services
{
    public class HelloEngService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Net Conf 2018 @ TaiChung");
        }
    }
}
