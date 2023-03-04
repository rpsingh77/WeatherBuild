using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Unity;
using WeatherApi.Controllers;

namespace WeatherApi.Test
{
    public class WeatherControllerTest
    {
        private WeatherController _controller;

        [SetUp]
        public void Setup()
        {
            var container = new TestContainer();
            var weatherService = container.Resolve<IWeatherService>();
            _controller = new WeatherController(weatherService);
        }

        [Test]
        public void ShouldGetBangaloreTemperature()
        {
            var city = "Bangalore";
            var result = _controller.GetTemperature(city);
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var okResult = result as OkObjectResult;
            Assert.That(okResult, Is.Not.Null);
            if(okResult != null && okResult.Value is not null)
            {
                var temp = (int)okResult.Value;
                Assert.IsTrue(temp > 0);
            }
        }

        [Test]
        public void ShouldGetNewYorkTemperature()
        {
            var city = "NewYork";
            var result = _controller.GetTemperature(city);
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var okResult = result as OkObjectResult;
            Assert.That(okResult, Is.Not.Null);
            if (okResult != null && okResult.Value is not null)
            {
                var temp = (int)okResult.Value;
                Assert.IsTrue(temp > 0);
            }
        }

        [Test]
        public void ShouldGetTemperature()
        {
            var city = "Hyderabad";
            Assert.Throws<Exception>(()=> { _controller.GetTemperature(city); });
        }
    }
}