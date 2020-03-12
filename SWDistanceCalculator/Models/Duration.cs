using SWDistanceCalculator.Enums;

namespace SWDistanceCalculator.Models
{
    public class Duration
    {
        /// <summary>
        /// How many of this quantity
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Wich kind of time unit
        /// </summary>
        public TimeUnit TimeUnit { get; set; }
        public Duration(int quantity, TimeUnit timeUnit)
        {
            Quantity = quantity;
            TimeUnit = timeUnit;
        }
    }
}