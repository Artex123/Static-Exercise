﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit) 
        {
            return (fahrenheit - 32) / 1.8;
        }
        public static double CelsiusToFahrenheit(double Celsius) 
        {
            return (Celsius * 9) / 5 + 32;
        }
    }
}
