using System;
using static SportsApp.Classes.Static.Common;

namespace SportsApp.Classes.Facilities
{
    // field facility capable of hosting soccer, athletics and other out door games
    public class Field : Facility
    {
        public Field(FacilityTypes facilityType)
        {
            base.FacilityType = facilityType;
        }

        public override void PlaySport(string sportName)
        {
            Console.WriteLine("Facility: {0} is being played at a large outdoor field. This is a {1} facility.", sportName, base.FacilityType.ToString());
        }
    }
}
