using DemoLifetime.Services;
using System;

namespace DemoLifetime
{
    public class App : IDisposable
    {
        private readonly GuidScopedService _service;

        public App(GuidScopedService service)
        {
            _service = service;
        }

        public void Run()
        {
            Console.WriteLine(_service.Guid);
        }

        public void Dispose()
        {
        }
    }
}
