using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPdotNET.CoordinateSystem;
using SGPdotNET.Observation;
using SGPdotNET.TLE;
using SGPdotNET.Util;
using System.IO;

namespace TLE_TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////var tle1 = "AQUA";
            ////var tle2 = "1 27424U 02022A   21245.83760660  .00000135  00000-0  39999-4 0  9997";
            ////var tle3 = "2 27424  98.2123 186.0654 0002229  67.6025 313.3829 14.57107527 28308";
            //var tle1 = "TERRA";
            //var tle2 = "1 25994U 99068A   21245.83721222  .00000061  00000-0  23592-4 0  9994";
            //var tle3 = "2 25994  98.1709 318.8263 0001450  94.8756  39.9198 14.57126728154614";
            //// Create a satellite from the TLEs
            //var sat = new Satellite(tle1, tle2, tle3);
            //// Set up our ground station location
            //var location = new GeodeticCoordinate(Angle.FromDegrees(34.16), Angle.FromDegrees(108.85), 0);
            //// Create a ground station
            //var groundStation = new GroundStation(location);
            ////var computeTime = new DateTime(2021, 09, 04, 5, 02, 45, DateTimeKind.Utc);
            //var computeTime = new DateTime(2021, 09, 05, 2, 26, 53, DateTimeKind.Utc);
            //List<SatelliteVisibilityPeriod> observationList = groundStation.Observe(sat, computeTime, computeTime + TimeSpan.FromDays(2), TimeSpan.FromMinutes(5),
            //    Angle.FromDegrees(15));
            //var observation = groundStation.Observe(sat, computeTime);
            //for (int i = 0; i < 1000; i++)
            //{
            //    computeTime = computeTime + TimeSpan.FromMilliseconds(100);
            //    observation = groundStation.Observe(sat, computeTime);
            //    Console.WriteLine(string.Format((computeTime + new TimeSpan(8, 0, 0)).ToString("yyyy.MM.dd HH:mm:ss:fff") + " EL:{1:f3};AZ:{0:f3}", observation.Azimuth.Degrees, observation.Elevation.Degrees));
            //}
            //Console.ReadLine();
            //StreamReader sr = new StreamReader(@"D:/LEADFILE");
            //double local_long =116.2;
            //double local_lat =39.56;
            //double local_height =100;
            //string tmp = string.Empty;
            //double az, el;
            //while(!string.IsNullOrEmpty(tmp=sr.ReadLine()))
            //{
            //    string[] list = tmp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    DateTime time = new DateTime(int.Parse(list[1]), int.Parse(list[2]), int.Parse(list[3]), int.Parse(list[4]),
            //        int.Parse(list[5]), int.Parse(list[6].Split('.')[0]), int.Parse(list[6].Split('.')[1]));
            //    calAZ_EL(local_long, local_lat, local_height,
            //        double.Parse(list[list.Length - 2]),
            //        double.Parse(list[list.Length - 3]),
            //        double.Parse(list[list.Length - 1]),
            //        out az, out el);
            //    Console.WriteLine(time.ToLongTimeString()+" 方位：{0:f2}，俯仰：{1:f2}", az, el);
            //}
            //Console.WriteLine("点击任意键结束");
            //while(Console.ReadLine()!=null)
            //{
            //    break;
            //}
            GlobalPosition position = new GlobalPosition();
            position.Longitude = 108.85;
            position.Latitude = 34.16;
            position.Altitude = 400;
            DateTime time = new DateTime(2022, 2, 27, 17, 11, 5);
            double az, el;
            SunCal.SolarPosition(position, time, out az, out el);
            Console.WriteLine("AZ:{0:F4},EL:{1:f4}", az, el);
        }
        static public void calAZ_EL(double local_long,double local_lat,double loacl_height,
            double target_long,double target_lat,double target_height,
            out double fangwei, out double fuyang)
        {
            const double pai = 3.1415926;
            double zxjLongitude_d = local_long;  //本地经度  dx1
            double zxjLatitude_d = local_lat;    //本地纬度  dy1
            double zxjHeight_d = loacl_height;        //本地高度   ah
            double zxjT_Longitude_d = target_long;  //目标经度  dx2
            double zxjT_Latitude_d = target_lat;    //目标纬度  dy2
            double zxjT_Height_d = target_height;      //目标高度   bh

            zxjLongitude_d = zxjLongitude_d * pai / 180;
            zxjLatitude_d = zxjLatitude_d * pai / 180;
            zxjT_Longitude_d = zxjT_Longitude_d * pai / 180;
            zxjT_Latitude_d = zxjT_Latitude_d * pai / 180;

            double Magnetic = 0;


            //计算方位
            double dlong;
            double angle;
            double x, y;
            dlong = zxjT_Longitude_d - zxjLongitude_d;
            angle = Math.Acos(Math.Cos(pai / 2 - zxjLatitude_d) * Math.Cos(pai / 2 - zxjT_Latitude_d) + Math.Sin(pai / 2 - zxjLatitude_d) * Math.Sin(pai / 2 - zxjT_Latitude_d) * Math.Cos(dlong));
            //fangwei = Math.Acos(Math.Sqrt(1 - Math.Pow(Math.Sin(pai / 2 - zxjT_Latitude_d) * Math.Sin(dlong) / Math.Sin(angle), 2)));
            y = Math.Sin(dlong) * Math.Cos(zxjT_Latitude_d);
            x = Math.Cos(zxjLatitude_d) * Math.Sin(zxjT_Latitude_d) - Math.Sin(zxjLatitude_d) * Math.Cos(zxjT_Latitude_d) * Math.Cos(dlong);
            fangwei = Math.Atan2(y, x);
            fangwei = fangwei * 180 / pai;
            fangwei = (fangwei + 360) % 360;


            //计算俯仰
            double hight1, hight2;
            double line;
            hight1 = zxjHeight_d + 6377830;
            hight2 = zxjT_Height_d + 6377830;
            line = Math.Sqrt(Math.Pow(hight1, 2) + Math.Pow(hight2, 2) - 2 * Math.Cos(angle) * hight1 * hight2);
            fuyang = Math.Acos(hight2 / line * Math.Sin(angle));
            fuyang = fuyang * 180 / pai;
        }
    }
    public class SunCal
    {
        private const double Deg2Rad = Math.PI / 180.0;
        private const double Rad2Deg = 180.0 / Math.PI;
        public static void CalculateSunPosition(
            DateTime dateTime, double latitude, double longitude,
            out double az, out double el)
        {
            // Convert to UTC
            dateTime = dateTime.ToUniversalTime();

            // Number of days from J2000.0.
            double julianDate = 367 * dateTime.Year -
              (int)((7.0 / 4.0) * (dateTime.Year +
              (int)((dateTime.Month + 9.0) / 12.0))) +
              (int)((275.0 * dateTime.Month) / 9.0) +
              dateTime.Day - 730531.5;

            double julianCenturies = julianDate / 36525.0;

            // Sidereal Time
            double siderealTimeHours = 6.6974 + 2400.0513 * julianCenturies;

            double siderealTimeUT = siderealTimeHours +
              (366.2422 / 365.2422) * (double)dateTime.TimeOfDay.TotalHours;

            double siderealTime = siderealTimeUT * 15 + longitude;

            // Refine to number of days (fractional) to specific time.
            julianDate += (double)dateTime.TimeOfDay.TotalHours / 24.0;
            julianCenturies = julianDate / 36525.0;

            // Solar Coordinates
            double meanLongitude = CorrectAngle(Deg2Rad *
              (280.466 + 36000.77 * julianCenturies));

            double meanAnomaly = CorrectAngle(Deg2Rad *
              (357.529 + 35999.05 * julianCenturies));

            double equationOfCenter = Deg2Rad * ((1.915 - 0.005 * julianCenturies) *
              Math.Sin(meanAnomaly) + 0.02 * Math.Sin(2 * meanAnomaly));

            double elipticalLongitude =
              CorrectAngle(meanLongitude + equationOfCenter);

            double obliquity = (23.439 - 0.013 * julianCenturies) * Deg2Rad;

            // Right Ascension
            double rightAscension = Math.Atan2(
              Math.Cos(obliquity) * Math.Sin(elipticalLongitude),
              Math.Cos(elipticalLongitude));

            double declination = Math.Asin(
              Math.Sin(rightAscension) * Math.Sin(obliquity));

            // Horizontal Coordinates
            double hourAngle = CorrectAngle(siderealTime * Deg2Rad) - rightAscension;

            if (hourAngle > Math.PI)
            {
                hourAngle -= 2 * Math.PI;
            }

            el = Math.Asin(Math.Sin(latitude * Deg2Rad) *
              Math.Sin(declination) + Math.Cos(latitude * Deg2Rad) *
              Math.Cos(declination) * Math.Cos(hourAngle));

            // Nominator and denominator for calculating Azimuth
            // angle. Needed to test which quadrant the angle is in.
            double aziNom = -Math.Sin(hourAngle);
            double aziDenom =
              Math.Tan(declination) * Math.Cos(latitude * Deg2Rad) -
              Math.Sin(latitude * Deg2Rad) * Math.Cos(hourAngle);

            az = Math.Atan(aziNom / aziDenom);

            if (aziDenom < 0) // In 2nd or 3rd quadrant
            {
                az += Math.PI;
            }
            else if (aziNom < 0) // In 4th quadrant
            {
                az += 2 * Math.PI;
            }

            az = az * Rad2Deg;
            el = el * Rad2Deg;
            // Altitude
            //Console.WriteLine("Altitude: " + altitude * Rad2Deg);

            // Azimut
            //Console.WriteLine("Azimuth: " + azimuth * Rad2Deg);
        }
        private static double CorrectAngle(double angleInRadians)
        {
            if (angleInRadians < 0)
            {
                return 2 * Math.PI - (Math.Abs(angleInRadians) % (2 * Math.PI));
            }
            else if (angleInRadians > 2 * Math.PI)
            {
                return angleInRadians % (2 * Math.PI);
            }
            else
            {
                return angleInRadians;
            }
        }
        public static void SolarPosition(GlobalPosition location, DateTimeOffset time,
            out double az, out double el)
        {
            double dtor = Math.PI / 180;

            int daysThisYear = DateTime.IsLeapYear(time.Year) ? 366 : 365;

            double fractionalYear = (2 * Math.PI / daysThisYear) * (time.DayOfYear - 1 + (time.Hour - 12) / 24);

            double equationOfTime = 229.18 * (0.000075
                                      + 0.001868 * Math.Cos(fractionalYear)
                                      - 0.032077 * Math.Sin(fractionalYear)
                                      - 0.014615 * Math.Cos(2 * fractionalYear)
                                      - 0.040849 * Math.Sin(2 * fractionalYear));

            double declination = 0.006918
                           - 0.399912 * Math.Cos(fractionalYear)
                           + 0.070257 * Math.Sin(fractionalYear)
                           - 0.006758 * Math.Cos(2 * fractionalYear)
                           + 0.000907 * Math.Sin(2 * fractionalYear)
                           - 0.002697 * Math.Cos(3 * fractionalYear)
                           + 0.001480 * Math.Sin(3 * fractionalYear);

            double timeOffset = equationOfTime + 4 * location.Longitude - time.Offset.TotalMinutes;
            double trueSolarTime = time.TimeOfDay.TotalMinutes + timeOffset;
            double hourAngle = trueSolarTime / 4 - 180;
            el = Math.Asin(Math.Sin(location.Latitude * dtor) * Math.Sin(declination) + Math.Cos(location.Latitude * dtor) * Math.Cos(declination) * Math.Cos(hourAngle * dtor)) / dtor;

            double azNom = -Math.Sin(hourAngle * dtor);
            double azDen = Math.Tan(declination) * Math.Cos(location.Latitude * dtor) - Math.Sin(location.Latitude * dtor) * Math.Cos(hourAngle * dtor);
            az = Math.Atan(azNom / azDen);

            if (azDen < 0)
            {
                az += Math.PI;
            }
            else if (azNom < 0)
            {
                az += 2 * Math.PI;
            }
            az = az * Rad2Deg;
        }
    }
    public class GlobalPosition
    {
        public double Latitude;
        public double Longitude;
        /// <summary>
        /// The altitude, in metres.
        /// </summary>
        public double Altitude;
    }
}
