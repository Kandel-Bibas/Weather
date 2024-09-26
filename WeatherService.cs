using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Weather;
public static class WeatherService
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<WeatherResponse> GetWeatherAsync(double latitude, double longitude)
    {
        // API endpoint with dynamic latitude and longitude values
        var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m&daily=weather_code&timezone=America%2FLos_Angeles";


        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var weatherData = JsonConvert.DeserializeObject<WeatherResponse>(content);
            return weatherData;
        }

        return null;
    }
}