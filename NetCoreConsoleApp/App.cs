using NetCoreConsoleApp.Interfaces;

namespace NetCoreConsoleApp
{
    public class App
    {
        private readonly IHelloService _service;
        public App(IHelloService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.SayHello();
        }
    }
}
