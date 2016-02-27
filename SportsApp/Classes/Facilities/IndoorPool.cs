using System;
using static SportsApp.Classes.Static.Common;

namespace SportsApp.Classes.Facilities
{
    public class IndoorPool : Facility
    {
        public IndoorPool(FacilityTypes facilityType)
        {
            base.FacilityType = facilityType;
        }

        public override void PlaySport(string sportName)
        {
            Console.WriteLine("Facility: {0} is happening in a indoor pool.. This is a {1} facility.", sportName, base.FacilityType.ToString());
            Console.WriteLine(string.Empty);
        }
    }
}
