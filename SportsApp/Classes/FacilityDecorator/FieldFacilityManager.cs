using SportsApp.Classes.Static;
using System;

namespace SportsApp.Classes.FacilityDecorator
{
    public class FieldFacilityManager : FacilityManager
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="facilityManager"></param>
        public FieldFacilityManager(FacilityManager facilityManager)
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
            Common.SetColor(ConsoleColor.Yellow);

            // prepare the faciltiy
            Console.WriteLine("Field facility manager preparing facility. (_ (_)  _) ");

            base.PrepareFacility();

            Common.SetColor(ConsoleColor.White);
        }
    }
}
