using SportsApp.Classes.Static;
using System;

namespace SportsApp.Classes.FacilityDecorator
{
    public  class SwimmingPoolFacilityManager : FacilityManager
    {
        // in case we need help from another facility manager
        private FacilityManager _facilityManager;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="facilityManager"></param>
        public SwimmingPoolFacilityManager(FacilityManager facilityManager)
        {
            _facilityManager = facilityManager;
        }

        /// <summary>
        /// prepare the facility and call another facility managers prepare facility
        /// </summary>
        public override void PrepareFacility()
        {
            base.PrepareFacility();

            Common.SetColor(ConsoleColor.Yellow);

            // prepare the faciltiy
            Console.WriteLine("Swimming pool facility manager preparing the pool and adding lanes. |--:) ");

            Common.SetColor(ConsoleColor.White);
        }
    }
}
