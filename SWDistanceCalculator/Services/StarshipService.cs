using SWDistanceCalculator.Builder;
using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWDistanceCalculator.Services
{
    /// <summary>
    /// Class responsible to fetch values from the SWApi
    /// </summary>
    public class StarshipService : IStarshipService
    {
        public readonly StarshipBuilder _builder;
        public StarshipService(StarshipBuilder builder)
        {
            _builder = builder;
        }
        /// <summary>
        /// Returns all starships from api
        /// </summary>
        /// <returns></returns>
        public async Task<List<Starship>> GetAll()
        {
            var api = new StarWarsAPI.StarWarsAPIClient();
            var starships = new List<Starship>();
            while (true)
            {
                var page = await api.GetAllStarship();
                starships.AddRange(page.results.Select(result => _builder.BuildStarshipFromApi(result)));
                if (!page.isNext)
                    break;
            }
            return starships;
        }
    }
}