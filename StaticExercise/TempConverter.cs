using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
       
        public static double FahrenheitToCelsius(double fctemp)
        {
            return  (fctemp - 32) * (5.0/9.0);
        }

        public static double CelsiusToFahrenheit(double cftemp)
        {
            return (cftemp * (9.0/5.0)) + 32;
        }
    }
}
