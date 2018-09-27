using System;

namespace DemoLifetime.Services
{
    public class GuidSingletonService
    {
        public Guid Guid { get; set; }

        public GuidSingletonService()
        {
            Guid = Guid.NewGuid();
        }

        public void ShowGuid()
        {
            Console.WriteLine(Guid);
        }
    }
}
