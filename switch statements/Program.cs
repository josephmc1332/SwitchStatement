using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch statements
            string[] daysOfTheWeek = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" }; 
            // inital switch statement using array specififying the fifth seat.
            switch (daysOfTheWeek [5])
            {
                //standard switch format. each case to display text using console.writeline. & break to prevent leak
                case "sunday":
                    Console.WriteLine("day one");
                    break;

                case "monday":
                    Console.WriteLine("day two");
                    break;

                case "tuesday":
                    Console.WriteLine("day three");
                    break;

                case "wednesday":
                    Console.WriteLine("day four");
                    break;

                case "thursay":
                    Console.WriteLine("day five");
                    break;

                case "friday":
                    Console.WriteLine("day six");
                    break;

                case "saturday":
                    Console.WriteLine("day seven");
                    break;

                //default statement to prevent crash from requests outside of array
                default:
                    Console.WriteLine("do not recognize your answer");
                    break;
            }

        }
    }
}
