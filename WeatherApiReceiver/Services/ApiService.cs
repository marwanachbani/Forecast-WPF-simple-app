using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiReceiver.Models;

namespace WeatherApiReceiver.Services
{
    public class ApiService
    {
        private const string ApiKey = "fac68516cdf0460998f11743242705";
        private const string BaseUrl = "http://api.weatherapi.com/v1/current.json";

        public async Task<WeatherInfo> GetWeatherInfoAsync(string city)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest();
            request.AddParameter("key", ApiKey);
            request.AddParameter("q", city);

            var response = await client.ExecuteGetAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<WeatherInfo>(response.Content);
            }
            return null;
        }
    }
}
