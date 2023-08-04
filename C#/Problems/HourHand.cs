using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public class HourHand
    {
        public static void Run()
        {
            int Angle = 0;
            
            if (!int.TryParse(Debug.ReadInput("Enter the angle of the hour hand: "), out Angle))
            {
                Debug.Write("Error: You must use an integer for the angle...");
                Run();
                return;
            }
            

            Debug.Result($"{Angle}° places the hour hand at {GetHour(Angle)}");
        }

        public static void RunAngleToHour()
        {
            int Hour = 1;
            int Minute = 0;

            Debug.Result($"Current time is {DateTime.Now.ToString("hh")}h {DateTime.Now.Minute}m, the current angle between minute and hour is {GetAngleBetweenHourAndMinuteHand(Convert.ToInt32(DateTime.Now.ToString("hh")), DateTime.Now.Minute)}° ");

            if (!int.TryParse(Debug.ReadInput("Enter the hour: "), out Hour))
            {
                Debug.Write("Error: You must use an integer for the Hour...");
                RunAngleToHour();
                return;
            }

            if (!int.TryParse(Debug.ReadInput("Enter the minute: "), out Minute))
            {
                Debug.Write("Error: You must use an integer for the minute...");
                RunAngleToHour();
                return;
            }

            

            Debug.Result($"The angle for {Hour}h, {Minute}m is {GetAngleBetweenHourAndMinuteHand(Hour, Minute)}°");
        }

        public static double GetAngleBetweenHourAndMinuteHand(int hour, int minute)
        {
            return Math.Round(Math.Abs(5 * ((6 * hour) - (1.1 * minute))), 2);
        }

        public static int GetHour(int Angle)
        {
            return Angle / (360 / 12);
        }

        public static int GetAngleFromHour(int Hour)
        {
            return Hour / (360 * 12);
        }
    }
}
