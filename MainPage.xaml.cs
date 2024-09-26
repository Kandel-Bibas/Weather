namespace Weather;

public partial class MainPage : ContentPage
{
    private LocationService locationService;

    public MainPage()
    {
        InitializeComponent();
        
        moderd.CheckedChanged += (s, args) =>
        {
            if (args.Value)
            {

                bgcolor.BackgroundColor = Color.Parse("#E56910");
                Wthrbox.BackgroundColor = Color.Parse("#6CC3E0");
            }
            else
            {

                bgcolor.BackgroundColor = Color.Parse("#091E427D");
                Wthrbox.BackgroundColor = Color.Parse("Gray");
            }
        };



        tempbdrbox.IsVisible = false;
    }
    
    private async void Search(object sender, EventArgs e)
    {
        bool isValidInput = int.TryParse(locationtxt.Text, out int zip_code);
        if (!isValidInput)
        {
            await DisplayAlert("Error", "Invalid Input (Enter US Zipcode only)", "Close");
            return;
        }
        await FetchLocationData(zip_code);

    }
    
    private async Task FetchLocationData(int zip_code)
    {
        try
        {
            // Fetch location data using the ZipLocation class
            var locationdata = await ZipLocation.GetLocationAsync(zip_code);

            // Check if location data is not null
            if (locationdata != null)
            {
                // Access the properties directly from locationdata
                var lat = locationdata.Lat;
                var lon = locationdata.Lon;
                var name = locationdata.Name;

                // Store the LocationService object in the class-level variable
                locationService = locationdata; // Directly assign the fetched locationdata to locationService


                // await DisplayAlert("Location Found", $"Latitude: {lat}, Longitude: {lon}", "OK");


                LocationName.Text = name;
                tempbdrbox.IsVisible = true;
                Temperature.Text = "Loading";
                await FetchWeatherData(lat, lon);

            }
            else
            {
                await DisplayAlert("Error", "Invalid ZIP code or data not found", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
        }
    }
    
    private async Task FetchWeatherData(double latitude, double longitude)
    {
        try
        {
            var weatherData = await WeatherService.GetWeatherAsync(latitude, longitude);

            if (weatherData != null)
            {
                tempbdrbox.IsVisible = true;
                Temperature.Text = $"{weatherData.hourly.temperature_2m[0]} °C";
                int weatherCode = weatherData.daily.weather_code[0]; // Example weather code
                string description = WeatherDescriptions.WeatherCodeDescriptions[weatherCode];
                Wthrimg.Source = WeatherIcons.WeatherCodeIcons[weatherCode];
                weathercondition.Text = description;
            }
            else
            {
                Temperature.Text = "Unable to retrieve data";
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to fetch weather data: {ex.Message}", "Close");
            Temperature.Text = "Error retrieving data";
        }
    }
    
}

public class LocationService
{

    public string Zip { get; set; }


    public string Name { get; set; }


    public double Lat { get; set; }


    public double Lon { get; set; }


    public string Country { get; set; }
}

public class WeatherResponse
{
    public Hourly hourly { get; set; }
    public Daily daily { get; set; }
}

public class Hourly
{
    public List<double> temperature_2m { get; set; }

}
public class Daily
{

    public List<int> weather_code { get; set; }
}

