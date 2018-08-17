using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    class Singleton
    {
        private static Singleton instance = null;
        private static bool pluggedIn = false;
        private static string currentGuitar = String.Empty;

        private Singleton() { }

        public static Singleton PlugIn(string guitar)
        {

            if (instance == null)
            {
                Console.WriteLine($"You have plugged in {guitar} to guitar amplifier.");
                instance = new Singleton();
                pluggedIn = true;
                currentGuitar = guitar;
            }
            else
            {
                Console.WriteLine($"Sorry but cabel already in use by {currentGuitar}.");
            }
            return instance;
        }

        public static void IsPluggedIn(string guitarName)
        {
            if (guitarName.Equals(currentGuitar) && pluggedIn)
            {
                Console.WriteLine($"{guitarName} is plugged into the guitar amplifier.");
            }
            else
            {
                Console.WriteLine($"{guitarName} is NOT plugged into the guitar amplifier.");
            }
        }
    }
}
