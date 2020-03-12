using SWDistanceCalculator.Enums;
using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Models;
using System;

namespace SWDistanceCalculator.Utils
{
    public class Parser : IParser
    {
        public Duration ParseConsumables(string consumablesValue)
        {
            if (string.IsNullOrWhiteSpace(consumablesValue))
                throw new ArgumentException(nameof(consumablesValue));
            var words = consumablesValue.Split(' ');
            var wordCount = words.Length;
            if(wordCount != 2)            
                return new Duration(-1, TimeUnit.NotValid);
            return new Duration(words[0].ToInt(), ParseTimeUnit(words[1]));
        }

        public TimeUnit ParseTimeUnit(string unitValue)
        {
            switch (unitValue)
            {
                case "day":
                case "days":
                    return TimeUnit.Day;
                case "week":
                case "weeks":
                    return TimeUnit.Week;
                case "month":
                case "months":
                    return TimeUnit.Month;
                case "year":
                case "years":
                    return TimeUnit.Year;
            }
            return TimeUnit.NotValid;
        }
    }
}
