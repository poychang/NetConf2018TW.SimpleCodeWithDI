using System;

namespace DemoLifetime.Services
{
    public class GuidScopedService
    {
        public Guid Guid { get; set; }

        public GuidScopedService()
        {
            Guid = Guid.NewGuid();
        }

        public void ShowGuid()
        {
            Console.WriteLine(Guid);
        }
    }
}
