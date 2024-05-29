using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public static class NetworkHelper
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<bool> IsConnectedToInternet()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://www.google.com");
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
