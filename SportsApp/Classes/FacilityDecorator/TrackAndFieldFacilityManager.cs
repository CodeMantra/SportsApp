using SportsApp.Classes.Static;
using System;
using static SportsApp.Classes.Static.Common;

namespace SportsApp.Classes.FacilityDecorator
{
    public class TrackAndFieldFacilityManager : FacilityManager
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="facilityManager"></param>
        public TrackAndFieldFacilityManager(FacilityManager facilityManager)
        {
            // multiple facility managers can prepare the facility
            // so we chain the facility managers so that they can do work pne after the other
            base.NextFacilityManager = facilityManager;
        }

        /// <summary>
        /// prepare the facility and call another facility managers prepare facility
        /// </summary>
        public override void PrepareFacility()
        {
            base.PrepareFacility();

            Common.SetColor(ConsoleColor.Yellow);

            // prepare the faciltiy
            Console.WriteLine("Facility manager preparing running tracks. =========");

            Common.SetColor(ConsoleColor.White);
        }
    }
}
