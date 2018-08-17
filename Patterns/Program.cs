using Patterns.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample();
            BuilderExample();
            AdapterExample();
            DecoratorExample();
            FacadeExample();
            FactoryMethod();
        }

        public static void Split(string text)
        {
            Console.WriteLine($"\n----------{text}----------");
        }

        public static void blankLine()
        {
            Console.WriteLine("");
        }

        public static void SingletonExample()
        {
            Split("Singleton");
            var guitar1 = Singleton.PlugIn("LTD m100fm");
            var guitar2 = Singleton.PlugIn("Jackson js22-7");
            var guitar3 = Singleton.PlugIn("Cort g200");
            blankLine();
            Singleton.IsPluggedIn("LTD m100fm");
            Singleton.IsPluggedIn("Jackson js22-7");
            Singleton.IsPluggedIn("Cort g200");
        }

        public static void BuilderExample()
        {
            blankLine();
            Split("Builder");
            var PCcreator = new BuilderAndStrategy(new MajorPC(), new WaterCooling());
            PCcreator.CreatePC();

            var PC = PCcreator.GetPC();
            PC.ShowInfo();
            PCcreator.Cooling();
        }

        public static void AdapterExample()
        {
            blankLine();
            Split("AdapterExample");
            Device device = new Device();
            SmartPhone phone = new SmartPhone();
            device.MemoryCardSlot(phone);

            Camera camera = new Camera();
            IMemoryMicroSD SD_Adapter = new FabricMethod(camera);

            device.MemoryCardSlot(SD_Adapter);
        }

        public static void DecoratorExample()
        {
            blankLine();
            Split("Decorator");
            var newCase = new PhoneCase(new Sony());
            newCase.IsPhoneCasePresented();
        }

        public static void FacadeExample()
        {
            blankLine();
            Split("Facade");

            RAMModule ram = new RAMModule();
            AppModule app = new AppModule();
            RegistryModule regx = new RegistryModule();

            Facade cleaner = new Facade(ram,app,regx);

            User user = new User();
            user.StartCleaning(cleaner);
        }

        public static void FactoryMethod()
        {
            blankLine();
            Split("FactoryMethod");

            Workshop work = new WestCoastCustoms("West Coast Customs");
            Car ride = work.Create();
        }
    }
}
