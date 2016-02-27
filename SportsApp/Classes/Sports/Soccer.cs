using SportsApp.Classes.Facilities;

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

        public Soccer(string name, Facility facility, string[] equipments)
                : base (name, facility, equipments)
        {
            //empty constructor
        }
    }
}
