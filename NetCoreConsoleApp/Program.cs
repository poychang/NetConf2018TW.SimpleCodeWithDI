using Microsoft.Extensions.DependencyInjection;
using NetCoreConsoleApp.Interfaces;
using NetCoreConsoleApp.Services;

namespace NetCoreConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 建立依賴注入的容器
            var serviceCollection = new ServiceCollection();
            // 註冊服務
            serviceCollection.AddTransient<App>();
            serviceCollection.AddTransient<IHelloService, HelloChtService>();
            // 建立依賴服務提供者
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // 執行主服務
            serviceProvider.GetService<App>().Run();
        }
    }
}
