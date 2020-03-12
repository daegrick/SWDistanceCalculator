using SWDistanceCalculator.Enums;
using SWDistanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDistanceCalculator.Interfaces
{
    public interface IParser
    {
        TimeUnit ParseTimeUnit(string unitValue);
        Duration ParseConsumables(string consumablesValue);
    }
}
