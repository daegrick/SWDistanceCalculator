using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Models;
using System;

namespace SWDistanceCalculator.Utils
{
    /// <summary>
    /// Calculates hours from duration and how many stops are needed to resupply
    /// </summary>
    public class Calculator : ICalculator
    {
        private const int DAY_IN_HOURS = 24;
        private const int WEEK_IN_HOURS = 168;
        private const int MONTH_IN_HOURS = 720;
        private const int YEAR_IN_HOURS = 8760;

        public long CalculateHours(Duration duration)
        {
            long partialHours;
            switch (duration.TimeUnit)
            {
                case Enums.TimeUnit.Day:
                    partialHours =  DAY_IN_HOURS;
                    break;
                case Enums.TimeUnit.Week:
                    partialHours = WEEK_IN_HOURS;
                    break;
                case Enums.TimeUnit.Month:
                    partialHours = MONTH_IN_HOURS;
                    break;
                case Enums.TimeUnit.Year:
                    partialHours = YEAR_IN_HOURS;
                    break;
                case Enums.TimeUnit.NotValid:
                default:
                    throw new ArgumentException(nameof(duration.TimeUnit));
            }
            return partialHours * duration.Quantity;
        }

        public long CalculateStops(long distanceMGLT, long spaceShipMGLT, long hours)
        {
            return distanceMGLT / (spaceShipMGLT * hours);
        }
    }
}
