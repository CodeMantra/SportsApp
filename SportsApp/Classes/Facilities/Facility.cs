using static SportsApp.Classes.Static.Common;

namespace SportsApp.Classes.Facilities
{
    public abstract class Facility
    {
        // type of facility
        protected FacilityTypes FacilityType { get; set; }

        /// <summary>
        /// facility specific information to play the game
        /// </summary>
        /// <param name="sportName"></param>
        public abstract void PlaySport(string sportName);
    }
}
