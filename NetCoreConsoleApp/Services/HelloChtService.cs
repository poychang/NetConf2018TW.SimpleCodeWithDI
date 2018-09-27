using NetCoreConsoleApp.Interfaces;
using System;

namespace NetCoreConsoleApp.Services
{
    public class HelloChtService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("哈囉 Net Conf 2018 在台中");
        }
    }
}
