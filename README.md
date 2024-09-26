# Weather

A simple C# weather application that fetches and displays real-time weather data for a specified location using a weather API.

## Features

- **Real-time Weather Data**: Fetches current weather conditions such as temperature, humidity, and wind speed.
- **API Integration**: Connects to a weather API to retrieve data for any location.
- **Simple User Interface**: Easy-to-use interface for selecting and viewing weather details.

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Kandel-Bibas/WeatherApp.git
2. **Navigate to the project directory:**
   ```bash
   cd Weather
3. **Build the application:** Open the project in Visual Studio or use the command line to build it using the following command:
   ```bash
   dotnet build
   
## Configuration
  To make the API requests work, you will need an API key from a weather service like OpenWeatherMap. Once you have the API key, add it to the application configuration file.
1. Go to the [APIKEY.cs](APIKEY.cs) file. 
2. Add your API key
   ```C#
   private string? apiKey = "Add-your-API Key-here";

## Usage
1. Run the application:
   ```bash
   dotnet run
2. Enter a U.S Zipcode for which you want to check weather then press search button.
3. The application will display the current weather data, including temperature, and weather condition

## Weather Icons
All weather icons used in this application were downloaded from [Flaticon](https://www.flaticon.com/) . Make sure to check their website for more icons and proper attribution guidelines.

## Contributing
If you want to contribute to the development of this weather application, feel free to fork the repository and create a pull request.
1. Fork the repository
2. Create a new branch:
   ```bash
   git checkout -b feature-branch
3. Make your changes
4. Commit your changes:
   ```bash
   git commit -m 'Add some feature'
5. Push to branch:
   ```bash
   git push origin feature-branch
6. Create a pull request

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.


