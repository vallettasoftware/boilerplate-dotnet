using BoilerplateApi.Entities;

namespace BoilerplateApiTests.Entities
{
    public class WeatherForecastTest
    {
        [Fact]
        public void CelsiusToFahrenheitTest()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 1,
                Summary = "Test"
            };

            Assert.Equal(32 + (int)(1 / 0.5556), weatherForecast.TemperatureF);
        }
    }
}
