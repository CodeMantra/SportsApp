using System;

namespace SportsApp.Classes.Static
{
    public static class Common
    {
        // different types of facilities
        public enum FacilityTypes
        {
            IndoorCourt,
            IndoorField,
            OutdoorCourt,
            OutDoorField,
            IndoorPool,
            OutDoorPool
        }

        public static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
