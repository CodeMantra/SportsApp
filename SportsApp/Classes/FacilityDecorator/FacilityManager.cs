using SportsApp.Classes.Sports;
using System;

namespace SportsApp.Classes.FacilityDecorator
{
    public abstract class FacilityManager
    {
        // in case we need help from another facility manager
        protected FacilityManager NextFacilityManager { get; set; }

        // abstract class to prepare each facility
        public virtual void PrepareFacility()
        {
            // verify if we need to call another facility manager
            if (NextFacilityManager != null)
            {
                NextFacilityManager.PrepareFacility();
            }
        }
    }
}
