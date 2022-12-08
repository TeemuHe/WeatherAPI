﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public class Weather
    {
        public string City { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }
        public string Description { get; set; }
    }
}
