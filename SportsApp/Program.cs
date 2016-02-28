using SportsApp.Classes.Facilities;
using SportsApp.Classes.FacilityDecorator;
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
            // each facility can be used by multiple sports
            Field soccerField = new Field(FacilityTypes.OutDoorField);
            IndoorPool deepPool = new IndoorPool(FacilityTypes.IndoorPool);

            // define the facility managers
            // each sport will require a facility to be prepared by appropriate facility manager
            // example: field facility can be used for multiple sports like soccer and athletics
            // only soccer facility manager knows how to prepare the facility for soccer
            // only track and field facility manager can prepare the facility for athletics
            FieldFacilityManager soccerFieldFaciltyManager = new FieldFacilityManager(null);
            SwimmingPoolFacilityManager swimmingPoolFacilityManager = new SwimmingPoolFacilityManager(null);

            // create the list of sports
            List<Sport> sportsList = new List<Sport>
            {
                new Soccer("Soccer", soccerField, soccerFieldFaciltyManager, new string[] { "Soccer ball", "Shoes" }),
                new Swimming("Swimming", deepPool, swimmingPoolFacilityManager, new string[] { "Swimming hat", "Swimming glasses" })
            };

            // play each game
            sportsList.ForEach(sp =>
                {
                    // prepare the facility and start the game
                    sp.PrepareFacility();
                    sp.StartGame();
                    Console.WriteLine("_____________________________________________________________");
                }
            );

            Console.WriteLine("Game over. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
