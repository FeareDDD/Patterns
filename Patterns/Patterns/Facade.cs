using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    class Facade
    {
        RAMModule ram;
        AppModule app;
        RegistryModule regx;

        public Facade(RAMModule ram, AppModule app, RegistryModule regx)
        {
            this.ram = ram;
            this.app = app;
            this.regx = regx;
        }
        public void Start()
        {
            ram.CleanRAM();
            app.CleanAppTrash();
            regx.CleanRegx();
        }
        public void Stop()
        {
            Console.WriteLine("Finish");
        }
    }

    class RAMModule
    {
        public void CleanRAM()
        {
            Console.WriteLine("Cleaning RAM");
        }
    }

    class AppModule
    {
        public void CleanAppTrash()
        {
            Console.WriteLine("Cleaning unused files and broken apps");
        }
    }

    class RegistryModule
    {
        public void CleanRegx()
        {
            Console.WriteLine("Cleaning registry");
        }
    }

    class User
    {
        public void StartCleaning(Facade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
