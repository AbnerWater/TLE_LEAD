using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPdotNET.CoordinateSystem;
using SGPdotNET.Observation;
using SGPdotNET.TLE;
using SGPdotNET.Util;

namespace TLE_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tle1 = "AQUA";
            //var tle2 = "1 27424U 02022A   21245.83760660  .00000135  00000-0  39999-4 0  9997";
            //var tle3 = "2 27424  98.2123 186.0654 0002229  67.6025 313.3829 14.57107527 28308";

            var tle1 = "TERRA";
            var tle2 = "1 25994U 99068A   21245.83721222  .00000061  00000-0  23592-4 0  9994";
            var tle3 = "2 25994  98.1709 318.8263 0001450  94.8756  39.9198 14.57126728154614";

            // Create a satellite from the TLEs
            var sat = new Satellite(tle1, tle2, tle3);

            // Set up our ground station location
            var location = new GeodeticCoordinate(Angle.FromDegrees(34.16), Angle.FromDegrees(108.85), 0);

            // Create a ground station
            var groundStation = new GroundStation(location);

            //var computeTime = new DateTime(2021, 09, 04, 5, 02, 45, DateTimeKind.Utc);
            var computeTime = new DateTime(2021, 09, 05, 2, 26, 53, DateTimeKind.Utc);
            List<SatelliteVisibilityPeriod> observationList = groundStation.Observe(sat, computeTime, computeTime + TimeSpan.FromDays(2), TimeSpan.FromMinutes(5),
                Angle.FromDegrees(15));
            var observation = groundStation.Observe(sat, computeTime);
            for (int i = 0; i < 1000; i++)
            {
                computeTime = computeTime + TimeSpan.FromMilliseconds(100);
                observation = groundStation.Observe(sat, computeTime);
                Console.WriteLine(string.Format((computeTime + new TimeSpan(8, 0, 0)).ToString("yyyy.MM.dd HH:mm:ss:fff") + " EL:{1:f3};AZ:{0:f3}", observation.Azimuth.Degrees, observation.Elevation.Degrees));
            }
            Console.ReadLine();
        }
    }
}
