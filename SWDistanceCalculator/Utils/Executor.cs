using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWDistanceCalculator.Utils
{
    public class Executor
    {
        private IStarshipService starshipService;
        private ICalculator calculator;

        private List<Starship> starships;
        public Executor(IStarshipService starshipService, ICalculator calculator)
        {
            this.starshipService = starshipService;
            this.calculator = calculator;
        }
        public async Task Init()
        {
            starships = await starshipService.GetAll();
        }

        public void Run(long distance)
        {
            if (starships is null)
                throw new ArgumentException(nameof(starships));
            Console.WriteLine("Calculating...\n");
            foreach (var starship in starships)
            {
                if(starship.MGLT == -1)
                {
                    Console.WriteLine($"ERROR: Unknown MGLT value for {starship.Name}");
                    continue;
                }
                var hours = calculator.CalculateHours(starship.Consumables);
                var stops = calculator.CalculateStops(distance, starship.MGLT, hours);
                Console.WriteLine($"{starship.Name} needs {stops} stop(s)");
            }
        }
    }
}