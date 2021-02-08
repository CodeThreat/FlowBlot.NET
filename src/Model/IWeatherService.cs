using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBlot.Model
{
    public interface IWeatherService
    {
        string GetWeatherData(string city);
    }

    public class WeatherServiceFinder
    {
        public static IWeatherService FetchProvider()
        {
            return (IWeatherService) new Object();
        }
    }
}
