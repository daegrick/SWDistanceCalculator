using SWDistanceCalculator.Utils;

namespace SWDistanceCalculator.Models
{
    public class Starship
    {
        /// <summary>
        /// Name of this Starship
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Maximum Megalights this starship can travel per hour
        /// </summary>
        public int MGLT { get; set; }
        /// <summary>
        /// How long this starship can go without resuply its consumables
        /// </summary>
        public Duration Consumables { get; set; }

        public Starship(string name, int mglt, Duration consumables)
        {
            Name = name;
            MGLT = mglt;
            Consumables = consumables;
        }
    }
}