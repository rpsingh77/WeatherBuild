using Services.Interface;

namespace Services.Service
{
    public class WeatherService:IWeatherService
    {
        public WeatherService()
        {

        }
        private Dictionary<string, int> _temperatureDict = new Dictionary<string, int>
        {
            ["NewYork"] = 10,
            ["Bangalore"] = 25,
            ["Montreal"] = 15
        };

        public int GetTemperature(string city)
        {
            if (_temperatureDict.ContainsKey(city))
            {
                return _temperatureDict[city];
            }
            throw new Exception("Unknown city");
        }
    }
}
