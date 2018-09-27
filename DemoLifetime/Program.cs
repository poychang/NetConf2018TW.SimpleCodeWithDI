using DemoLifetime.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoLifetime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 建立依賴注入的容器
            var serviceCollection = new ServiceCollection();
            
            // 註冊服務
            serviceCollection.AddSingleton<GuidSingletonService>();
            serviceCollection.AddTransient<GuidTransientService>();
            serviceCollection.AddScoped<GuidScopedService>();
            serviceCollection.AddSingleton<App>();
            // 使用明確實作工廠的寫法
            //serviceCollection.AddSingleton<App>((IServiceProvider sp) => new App(sp.GetRequiredService<GuidScopedService>()));
            
            // 建立依賴服務提供者 (Service Locator)
            var serviceProvider = serviceCollection.BuildServiceProvider();

            do
            {
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.Clear();
                        break;
                    case "1":
                        DemoSingleton(serviceProvider);
                        break;
                    case "2":
                        DemoTransient(serviceProvider);
                        break;
                    case "3":
                        DemoScoped(serviceProvider);
                        break;
                    default:
                        return;
                }
            } while (true);
        }

        public static void DemoSingleton(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Demo AddSingleton(): 整個應用程式的生命週期內只會有一個實例");
            Console.WriteLine(serviceProvider.GetRequiredService<GuidSingletonService>().Guid);
            Console.WriteLine(serviceProvider.GetRequiredService<GuidSingletonService>().Guid);
            Console.WriteLine(serviceProvider.GetRequiredService<GuidSingletonService>().Guid);
        }

        public static void DemoTransient(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Demo AddTransient(): 每次注入都會產生一個新的實例");
            Console.WriteLine(serviceProvider.GetRequiredService<GuidTransientService>().Guid);
            Console.WriteLine(serviceProvider.GetRequiredService<GuidTransientService>().Guid);
            Console.WriteLine(serviceProvider.GetRequiredService<GuidTransientService>().Guid);
        }

        public static void DemoScoped(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Demo AddScoped(): 每個 Scope 範圍內使用同一個實例");
            // 透過 IServiceProvider.CreateScope() 建立 Scope 範圍
            using (var scope = serviceProvider.CreateScope())
            {
                Console.WriteLine($"Singleton: {serviceProvider.GetRequiredService<GuidSingletonService>().Guid}");
                Console.WriteLine($"Transient: {serviceProvider.GetRequiredService<GuidTransientService>().Guid}");
                Console.WriteLine($"Transient: {serviceProvider.GetRequiredService<GuidTransientService>().Guid}");
                Console.WriteLine($"Scoped: {scope.ServiceProvider.GetRequiredService<GuidScopedService>().Guid}");
                Console.WriteLine($"Scoped: {scope.ServiceProvider.GetRequiredService<GuidScopedService>().Guid}");
            }
        }
    }
}
