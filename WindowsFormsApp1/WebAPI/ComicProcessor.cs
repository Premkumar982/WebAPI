using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI
{
    public class ComicProcessor
    {
        public async Task<ComicDetails> LoadComicImages(int imageNumber = 0)
        {
            string url = "https://xkcd.com";
            APIHelper.InitialiseClient();
            if (imageNumber > 0)
                url = url + $"/{imageNumber}" + "/info.0.json";
            else
                url = url + "/info.0.json";

            using (HttpResponseMessage resp = await APIHelper.httpClient.GetAsync(url))
            {
                if(resp.IsSuccessStatusCode)
                {
                    var data = await resp.Content.ReadAsStringAsync();
                    ComicDetails comicData = JsonConvert.DeserializeObject<ComicDetails>(data);
                    return comicData;
                }
                else
                {
                    throw new Exception(resp.ReasonPhrase);
                }
            }
        }

    }
}
