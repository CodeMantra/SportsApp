using SportsApp.Classes.Facilities;

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

        public Swimming(string name, Facility facility, string[] equipments)
                : base (name, facility, equipments)
        {
            //empty constructor
        }
    }
}
