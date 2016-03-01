using SportsApp.Classes.Facilities;
using SportsApp.Classes.FacilityDecorator;

namespace SportsApp.Classes.Sports
{
    public class TrackAndField : Sport
    {
        public override string Rule
        {
            get
            {
                return "Participate in multiple events - 200 m race, long jump, high jump, discus throw. !!!";
            }
        }

        protected override FacilityManager SportFacilityManager
        {
            get; set;
        }

        public TrackAndField(string name, Facility facility, FacilityManager facilityManager, string[] equipments)
                : base (name, facility, equipments)
        {
            // set the facility manager
            SportFacilityManager = facilityManager;
        }
    }
}
