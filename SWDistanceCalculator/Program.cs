using SWDistanceCalculator.Builder;
using SWDistanceCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDistanceCalculator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var calculator = new Calculator();
            var parser = new Parser();
            var builder = new StarshipBuilder(parser);
            var service = new Services.StarshipService(builder);
            Executor executor = new Executor(service, calculator);
            await executor.Init();
            string input;            
            do
            {
                Console.WriteLine("\nPlease enter the distance in MGLT(Mega Lights) or type \"exit\" to exit program:");
                input = Console.ReadLine();
                executor.Run(input.ToInt());
            } while (input != "exit");
        }
    }
}