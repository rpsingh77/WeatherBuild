using Services.Interface;
using Services.Service;
using Unity;

namespace WeatherApi.Test
{
    public class TestContainer : UnityContainer
    {
        public TestContainer()
        {
            RegisterServices();
        }

        public void RegisterServices()
        {
            this.RegisterType<IWeatherService, WeatherService>();
        }
    }
}
