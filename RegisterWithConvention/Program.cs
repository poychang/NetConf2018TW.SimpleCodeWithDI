using Microsoft.Extensions.DependencyInjection;
using RegisterWithConvention.Extensions;
using RegisterWithConvention.Interfaces;
using RegisterWithConvention.Services;

namespace RegisterWithConvention
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 建立依賴注入的容器
            var serviceCollection = new ServiceCollection();
            
            // 註冊服務
            serviceCollection
                .AddTransient<App>()
                //.AddTransient<IHelloService, HelloChtService>()
                //.AddTransient<IHelloService, HelloEngService>();
                // 習慣取代配置，將 Service 結尾的類別都註冊進容器中
                .AddFromEntryAssembly(ServiceLifetime.Transient, service => service.Name.EndsWith("Service"));

            // 建立依賴服務提供者
            var serviceProvider = serviceCollection.BuildServiceProvider();

            serviceProvider.GetRequiredService<App>().Run();
        }
    }
}
