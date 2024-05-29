namespace WeatherApiReceiver.Models
{
    public class WeatherInfo
    {
        public Current Current { get; set; }
        public Location Location { get; set; }
    }

    public class Current
    {
        public float Temp_C { get; set; }
        public float Feelslike_C { get; set; }
        public float Pressure_MB { get; set; }
        public int Humidity { get; set; }
        public float Wind_Kph { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
