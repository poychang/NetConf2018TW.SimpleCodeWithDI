using System;

namespace DemoLifetime.Services
{
    public class GuidTransientService
    {
        public Guid Guid { get; set; }

        public GuidTransientService()
        {
            Guid = Guid.NewGuid();
        }

        public void ShowGuid()
        {
            Console.WriteLine(Guid);
        }
    }
}
