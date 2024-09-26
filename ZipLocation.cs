using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Weather;

public static class ZipLocation
{

    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<LocationService> GetLocationAsync(int zip_code)
    {
        APIKEY api = new APIKEY(); // Instantiate the class
        string apiKey = api.GetAPIKey(); // Access the API key

        var url = $"https://api.openweathermap.org/geo/1.0/zip?zip={zip_code},{"US"}&appid={apiKey}";

        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var locationdata = JsonConvert.DeserializeObject<LocationService>(content);
            return locationdata;
        }

        return null;
    }


}