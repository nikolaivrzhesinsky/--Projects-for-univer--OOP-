using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public static class MyExtensions
        {
            public static int ParseInt(this string value, int defaultValue = 0)
            {
                int parsedValue;
                if (int.TryParse(value, out parsedValue))
                {
                    return parsedValue;
                }

                return defaultValue;
        }
    }
}
