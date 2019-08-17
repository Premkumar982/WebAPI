using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI
{
    public class SunProcessor
    {
        public async Task<SunModel> LoadSunData(string Latitude, string Longitude)
        {
            APIHelper.InitialiseClient();
            string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400";
            using (HttpResponseMessage resp = await APIHelper.httpClient.GetAsync(url))
            {
                if(resp.IsSuccessStatusCode)
                {
                    var data = await resp.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<SunModelResult>(data);
                    return result.Results;
                }
                else
                {
                    throw new Exception(resp.ReasonPhrase);
                }
            }
        }
    }
}
 