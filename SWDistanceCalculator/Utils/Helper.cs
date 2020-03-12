namespace SWDistanceCalculator.Utils
{
    public static class Helper
    {
        public static int ToInt(this string value)
        {
            if (int.TryParse(value, out var finalValue))
            {
                return finalValue;
            }
            return -1;
        }
    }
}