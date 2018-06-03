using WeatherMicroservice.utils;
using WeatherMicroservice.BusinessDomain; 
using System.Collections.Generic;

namespace WeatherMicroservice.BusinessDomain {
    public class WeatherService {
        public WeatherService(){
            
        }
        public List<WeatherReport> GetWeatherForecast(string latString, string longString) {
            var latitude = latString.TryParse();
            var longitude = longString.TryParse();
            var forecast = new List<WeatherReport>();
            if (latitude.HasValue && longitude.HasValue)
            {            
                for (var days = 1; days < 6; days++)
                {
                    forecast.Add(new WeatherReport(latitude.Value, longitude.Value, days));
                }
            }
            return forecast;
        }
    }
}