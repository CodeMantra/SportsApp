using System;
using SportsApp.Classes.Facilities;
using SportsApp.Classes.FacilityDecorator;

namespace SportsApp.Classes.Sports
{
    public class Soccer : Sport
    {
        public override string Rule
        {
            get
            {
                return "Kick the ball and score a goal !!!";
            }
        }

        protected override FacilityManager SportFacilityManager
        {
            get; set;
        }

        public Soccer(string name, Facility facility, FacilityManager facilityManager, string[] equipments)
                : base (name, facility, equipments)
        {
            // set the facility manager
            SportFacilityManager = facilityManager;
        }
    }
}
