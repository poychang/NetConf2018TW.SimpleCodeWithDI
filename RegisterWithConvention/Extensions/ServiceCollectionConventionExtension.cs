using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace RegisterWithConvention.Extensions
{
    public static class ServiceCollectionConventionExtension
    {
        /// <summary>
        /// 從應用程式定義域中的處理序可執行檔，取得符合條件的類別進行依賴註冊
        /// </summary>
        /// <param name="services">擴充對象</param>
        /// <param name="lifetime">要註冊的生命週期</param>
        /// <param name="condition">習慣取代配置的條件</param>
        /// <returns></returns>
        public static IServiceCollection AddFromEntryAssembly(
            this IServiceCollection services,
            ServiceLifetime lifetime,
            Func<TypeInfo, bool> condition = null)
        {
            if (condition == null) return services;

            var assemblies = Assembly.GetEntryAssembly().DefinedTypes
                .Where(p => p.IsClass)
                .Where(condition);

            foreach (var @class in assemblies)
            {
                Console.WriteLine($"註冊 {@class.Name}");
                services.Add(new ServiceDescriptor(@class.AsType(), @class.AsType(), lifetime));

                foreach (var @interface in @class.GetInterfaces())
                {
                    Console.WriteLine($"註冊 {@class.Name} : {@interface.Name}");
                    services.Add(new ServiceDescriptor(@interface, @class.AsType(), lifetime));
                }
            }

            return services;
        }
    }
}
