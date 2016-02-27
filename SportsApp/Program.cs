using SportsApp.Classes.Facilities;
using SportsApp.Classes.Sports;
using System;
using System.Collections.Generic;
using static SportsApp.Classes.Static.Common;

namespace SportsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // define the facilities
            Field soccerFiled = new Field(FacilityTypes.OutDoorField);
            IndoorPool deepPool = new IndoorPool(FacilityTypes.IndoorPool);

            // create the list of sports
            List<Sport> sportsList = new List<Sport>
            {
                new Soccer("Soccer", soccerFiled, new string[] { "Soccer ball", "Shoes" }),
                new Swimming("Swimming", deepPool, new string[] { "Swimming hat", "Swimming glasses" })
            };

            // play each game
            sportsList.ForEach(sp => {
                    sp.StartGame();
                    Console.WriteLine("_____________________________________________________________");
                }
            );

            Console.WriteLine("Game over. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
