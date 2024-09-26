using System.Collections.Generic;

namespace Weather
{
    public static class WeatherIcons
    {
        public static readonly Dictionary<int, string> WeatherCodeIcons = new Dictionary<int, string>
        {
            { 0, "sun.png" }, // Assuming day icon for clear sky
            { 1, "mainly_clear.png" }, // Mainly clear (Day)
            { 2, "partly_cloudy.png" }, // Partly cloudy (Day)
            { 3, "overcast.png" }, // Overcast (Day)
            { 45, "fog.png" }, // Fog (Day)
            { 48, "fog_frost.png" }, // Depositing rime fog (Using fog icon)
            { 51, "light_drizzle.png" }, // Drizzle: Light intensity
            { 53, "drizzle_moderate" }, // Drizzle: Moderate intensity
            { 55, "heavy_drizzle.png" }, // Drizzle: Dense intensity
            { 56, "frost-day.svg" }, // Freezing Drizzle: Light intensity (Using frost icon)
            { 57, "frost-day.svg" }, // Freezing Drizzle: Dense intensity
            { 61, "rainy-1-day.svg" }, // Rain: Slight intensity
            { 63, "rainy-2-day.svg" }, // Rain: Moderate intensity
            { 65, "rainy-3-day.svg" }, // Rain: Heavy intensity
            { 66, "rain-and-sleet-mix.svg" }, // Freezing Rain: Light intensity
            { 67, "rain-and-sleet-mix.svg" }, // Freezing Rain: Heavy intensity
            { 71, "snowy-1-day.svg" }, // Snow fall: Slight intensity
            { 73, "snowy-2-day.svg" }, // Snow fall: Moderate intensity
            { 75, "snowy-3-day.svg" }, // Snow fall: Heavy intensity
            { 77, "snowy-1-day.svg" }, // Snow grains (Using light snow icon)
            { 80, "rainy-1-day.svg" }, // Rain showers: Slight intensity
            { 81, "rainy-2-day.svg" }, // Rain showers: Moderate intensity
            { 82, "rainy-3-day.svg" }, // Rain showers: Violent intensity
            { 85, "snowy-1-day.svg" }, // Snow showers: Slight intensity
            { 86, "snowy-2-day.svg" }, // Snow showers: Heavy intensity
            { 95, "isolated-thunderstorms-day.svg" }, // Thunderstorm: Slight or moderate
            { 96, "thunderstorms.svg" }, // Thunderstorm with slight hail
            { 99, "severe-thunderstorm.svg" } // Thunderstorm with heavy hail
        };
    }
}
