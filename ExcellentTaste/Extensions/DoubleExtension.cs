using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Extensions
{
    public static class DoubleExtension
    {
        public static double ConvertInput(string input)
        {
            input = input.Replace('.', ',');

            if (!double.TryParse(input, out double resultDouble))
            {
                resultDouble = 0.0;
            }

            return resultDouble = Math.Round(resultDouble, 2); ;
        }
    }
}