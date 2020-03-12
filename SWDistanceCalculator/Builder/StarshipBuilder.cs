using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Models;
using SWDistanceCalculator.Utils;

namespace SWDistanceCalculator.Builder
{
    public class StarshipBuilder
    {
        private readonly IParser Parser;
        private Starship _starship;
        public StarshipBuilder(IParser parser)
        {
            Parser = parser;
        }

        public Starship BuildStarshipFromApi(StarWarsAPI.Model.Starship starshipFromApi)
        {
            _starship = new Starship(
                name: starshipFromApi.name,
                mglt: starshipFromApi.MGLT.ToInt(),
                consumables: Parser.ParseConsumables(starshipFromApi.consumables));
            return _starship;
        }
    }
}