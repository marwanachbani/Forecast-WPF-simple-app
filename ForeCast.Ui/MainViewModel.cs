using Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApiReceiver.Models;
using WeatherApiReceiver.Services;

namespace ForeCast.Ui
{
    public class MainViewModel : INotifyPropertyChanged 
    {
        private readonly ApiService _apiService = new ApiService();
        
        private string city;
        private string longitude;
        private string response;
        private WeatherInfo weatherInfo;

        public string Response
        {
            get { return response; }
            set
            {
                response = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        

        public WeatherInfo WeatherInfo
        {
            get { return weatherInfo; }
            set
            {
                weatherInfo = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetWeatherInfoCommand { get; }

        public MainViewModel()
        {
            
          
          
                GetWeatherInfoCommand = new RelayCommand(async () => await GetWeatherInfo());
           
            
        }

        private async Task GetWeatherInfo()
        {
            Response = "";
            var connected = await NetworkHelper.IsConnectedToInternet();
            if(connected == true)
            {
                WeatherInfo = await _apiService.GetWeatherInfoAsync(city);
            }
            else
            {
                Response = "Not internet please reload the network";
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
