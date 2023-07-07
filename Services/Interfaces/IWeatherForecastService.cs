using WebApplication1.Models;
namespace WebApplication1.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> Find();
    }
}
