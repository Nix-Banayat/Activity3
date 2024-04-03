using System;

namespace Activity3;

internal class Program
{
    static void Main(string[] args)
    {
        int time = 0;

        do
        {
            Console.WriteLine("\nTIME CONVERTER\n");
            Console.WriteLine("Time Conversions");
            Console.WriteLine("1. Seconds to Minutes");
            Console.WriteLine("2. Minutes to Hours");
            Console.WriteLine("3. Hours to Days");
            Console.WriteLine("4. Days to Month");
            Console.Write("Which time conversion do you want to proceed: ");

            time = Convert.ToInt32(Console.ReadLine());

            switch (time)
            {
                case 1:
                    Console.Write("Enter the number of seconds: \n");
                    float seconds = Convert.ToInt32(Console.ReadLine());
                    float minutes = seconds / 60;
                    if (seconds == 1)
                    {
                        Console.WriteLine(seconds + " second is equivalent to " + minutes + " minute.");
                    }
                    else if (minutes > 1)
                    {
                        Console.WriteLine(seconds + " seconds is equivalent to " + minutes + " minutes.");
                    }
                    else
                    {
                        Console.WriteLine(seconds + " seconds is equivalent to " + minutes + " minute.");
                    }
                    break;

                case 2:
                    Console.Write("Enter the number of minutes: \n");
                    float minutes2 = Convert.ToInt32(Console.ReadLine());
                    float hours = minutes2 / 60;
                    if (minutes2 == 1)
                    {
                        Console.WriteLine(minutes2 + " minute is equivalent to " + hours + " hour.");
                    }
                    else if (hours > 1)
                    {
                        Console.WriteLine(minutes2 + " minutes is equivalent to " + hours + "hours.");
                    }
                    else
                    {
                        Console.WriteLine(minutes2 + " minutes is equivalent to " + hours + " hour.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the number of hours: \n");
                    float hours2 = Convert.ToInt32(Console.ReadLine());
                    float days = hours2 / 24;
                    if (hours2 == 1)
                    {
                        Console.WriteLine(hours2 + " hour is equivalent to " + days + " day.");
                    }
                    else if (days > 1)
                    {
                        Console.WriteLine(hours2 + " hours is equivalent to " + days + " days.");
                    }
                    else
                    {
                        Console.WriteLine(hours2 + " hours is equivalent to " + days + " day.");
                    }
                    break;

                case 4:
                    Console.Write("Enter the number of days: \n");
                    float days2 = Convert.ToInt32(Console.ReadLine());
                    float months = days2 / 30;  //Assuming that month has 30 days.
                    if (days2 == 1)
                    {
                        Console.WriteLine(days2 + " day is equivalent to " + months + " month.");
                    }
                    else if (months > 1)
                    {
                        Console.WriteLine(days2 + " days is equivalent to " + months + " months.");
                    }
                    else
                    {
                        Console.WriteLine(days2 + " days is equivalent to " + months + " month.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input. Please choose numbers 1 to 4 only in the Time Conversions.");
                    break;
            }
        } while (time > 0 && time < 5);
    }
}