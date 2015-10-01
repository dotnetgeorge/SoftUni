using System;
using GalacticGPSApp.Data;

namespace GalacticGPSApp
{
    class GalacticGPS
    {
        static void Main(string[] args)
        {
            var home = new Location(18.037986, 28.870097, Planet.Earth);

            Console.WriteLine(home);
        }
    }
}
