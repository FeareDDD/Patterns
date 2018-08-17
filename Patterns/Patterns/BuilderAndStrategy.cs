using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    public interface IPCBuilder
    {
        void SetProcessor();
        void SetVideoCard();
        void SetMotherboard();
        void SetRAM();
        void SetDrive();
        void SetPowerSupply();

        PC GetPC();
    }

    public interface IVentilator
    {
        void Cooling();
    }

    class BuilderAndStrategy
    {
        public IVentilator Ventil { private get; set; }
        public void Cooling()
        {
            Ventil.Cooling();
        }

        private readonly IPCBuilder objBuilder;

        public BuilderAndStrategy(IPCBuilder builder, IVentilator cooling)
        {

            objBuilder = builder;
            Ventil = cooling;
        }

        public void CreatePC()
        {
            objBuilder.SetProcessor();
            objBuilder.SetVideoCard();
            objBuilder.SetMotherboard();
            objBuilder.SetRAM();
            objBuilder.SetPowerSupply();
        }

        public PC GetPC()
        {
            return objBuilder.GetPC();
        }
    }

    public class MajorPC : IPCBuilder
    {
        PC objPC = new PC();

        public PC GetPC()
        {
            return objPC;
        }

        public void SetDrive()
        {
            objPC.Drive = "Toshiba 1TB 7200rpm";
        }

        public void SetMotherboard()
        {
            objPC.Motherboard = "ASUS Z370 SLI";
        }

        public void SetPowerSupply()
        {
            objPC.PowerSupply = "1200 Wt Aerocool";
        }

        public void SetProcessor()
        {
            objPC.Processor = "Intel Core i7-8086K";
        }

        public void SetRAM()
        {
            objPC.RAM = "64 GB Kingston";
        }

        public void SetVideoCard()
        {
            objPC.VideoCard = "nVidia GeForce GTX 1080Ti";
        }
    }

    public class BomjPC : IPCBuilder
    {
        PC objPC = new PC();

        public PC GetPC()
        {
            return objPC;
        }

        public void SetDrive()
        {
            objPC.Drive = "Toshiba 128GB 4800rpm";
        }

        public void SetMotherboard()
        {
            objPC.Motherboard = "ASUS B170 Bomj edition";
        }

        public void SetPowerSupply()
        {
            objPC.PowerSupply = "322 Wt";
        }

        public void SetProcessor()
        {
            objPC.Processor = "AMD Athlon";
        }

        public void SetRAM()
        {
            objPC.RAM = "128 MB";
        }

        public void SetVideoCard()
        {
            objPC.VideoCard = "No video card available";
        }
    }

    public class PC
    {
        public string Processor { get; set; }
        public string VideoCard { get; set; }
        public string Motherboard { get; set; }
        public string RAM { get; set; }
        public string Drive { get; set; }
        public string PowerSupply { get; set; }

        public PC()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"VideoCard: {VideoCard}");
            Console.WriteLine($"Motherboard: {Motherboard}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Drive: {Drive}");
            Console.WriteLine($"PowerSupply: {PowerSupply}");
        }
    }

    class BomjCooling : IVentilator
    {
        public void Cooling()
        {
            Console.WriteLine("Ventilator cooling");
        }
    }

    class WaterCooling : IVentilator
    {
        public void Cooling()
        {
            Console.WriteLine("Water cooling");
        }
    }
}
