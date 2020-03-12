using SWDistanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDistanceCalculator.Interfaces
{
    interface IStarshipService 
    {
        Task<List<Starship>> GetAll();
    }
}
