using System;
using RegisterWithConvention.Interfaces;

namespace RegisterWithConvention.Services
{
    public class HelloChtService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("哈囉 Net Conf 2018 在台中");
        }
    }
}
