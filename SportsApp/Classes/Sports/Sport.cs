using SportsApp.Classes.Facilities;
using System;

namespace SportsApp.Classes.Sports
{
    public abstract class Sport
    {
        // derived class will write custom rules
        public abstract string Rule { get; }

        // name of the sport
        public string Name { get; set; }

        // specify the facility
        protected Facility SportsFacility { get; set; }

        //specify the equipments
        protected string[] Equipments { get; set; }

        /// <summary>
        /// constructor to call base constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="facility"></param>
        /// <param name="equipments"></param>
        public Sport(string name, Facility facility, string[] equipments)
        {
            Name = name;
            SportsFacility = facility;
            Equipments = equipments;
        }

        public virtual void StartGame()
        {
            Console.WriteLine(string.Format("Sport {0} is being played with equipments {1}", this.Name, string.Join(", ", Equipments)));
            Console.WriteLine(string.Format("Rule: {0}", this.Rule));

            // play the sport in facility
            this.SportsFacility.PlaySport(this.Name);
        }
    }
}
