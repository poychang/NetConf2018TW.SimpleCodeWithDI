using System;
using RegisterWithConvention.Interfaces;

namespace RegisterWithConvention.Services
{
    public class HelloEngService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Net Conf 2018 @ TaiChung");
        }
    }
}
