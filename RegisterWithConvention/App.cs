using RegisterWithConvention.Interfaces;

namespace RegisterWithConvention
{
    public class App
    {
        // 注意！這裡要改成明確實作，否則會拿到最後註冊該介面的實作
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
