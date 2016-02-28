using SportsApp.Classes.Facilities;
using SportsApp.Classes.FacilityDecorator;

namespace SportsApp.Classes.Sports
{
    public class Swimming : Sport
    {
        public override string Rule
        {
            get
            {
                return "Jump into the pool and flip your legs in water fast. !!!";
            }
        }

        protected override FacilityManager SportFacilityManager
        {
            get; set;
        }

        public Swimming(string name, Facility facility, FacilityManager facilityManager, string[] equipments)
                : base (name, facility, equipments)
        {
            // set the facility manager
            SportFacilityManager = facilityManager;
        }
    }
}
