using Services.Interface;
using Services.Service;

namespace WeatherApi
{
    public static class Startup
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherService, WeatherService>();
        }
    }
}
