using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemeApiDotNetWrapper
{
    public class MemeMachine
    {
        private static HttpClient httpClient;

        public MemeMachine()
        {
            httpClient = new HttpClient();
        }

        public async Task<Meme> GetMeme()
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://meme-api.herokuapp.com/gimme");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Something has gone wrong, the API might be down. Please check at: https://meme-api.herokuapp.com/gimme");
            }
            else
            {
                return new Meme(JObject.Parse(await response.Content.ReadAsStringAsync()));
            }
        }
    }
}
