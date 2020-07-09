using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShouldIJog.Models
{

    public class WeatherForecastModel
    {
        public Weather[] Weather { get; set; }
        public TemperatureData Main { get; set; }
        public string Name { get; set; }
    }

}
