using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    interface IMemoryMicroSD
    {
        void UseMicroSDCard();
    }

    interface IMemorySD
    {
        void UseSDCard();
    }

    class Device
    {
        public void MemoryCardSlot(IMemoryMicroSD memory)
        {
            memory.UseMicroSDCard();
        }
    }

    class SmartPhone : IMemoryMicroSD
    {
        public void UseMicroSDCard()
        {
            Console.WriteLine("Using microSD card");
        }
    }

    class Camera : IMemorySD
    {
        public void UseSDCard()
        {
            Console.WriteLine("Using SD card");
        }
    }

    class FabricMethod: IMemoryMicroSD
    {
        Camera camera;
        public FabricMethod(Camera cam)
        {
            camera = cam;
        }

        public void UseMicroSDCard()
        {
            camera.UseSDCard();
        }
    }
}
