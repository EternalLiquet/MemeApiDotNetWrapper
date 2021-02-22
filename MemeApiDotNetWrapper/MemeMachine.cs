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

        public async Task<Meme> GetMeme(string subreddit = null)
        {
            string memeApiUrl = "https://meme-api.herokuapp.com/gimme";
            if (!string.IsNullOrEmpty(subreddit)) memeApiUrl += $"/{subreddit}";
            HttpResponseMessage response = await httpClient.GetAsync(memeApiUrl);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Something has gone wrong, the API might be down. Please check at: {memeApiUrl}");
            }
            else
            {
                return new Meme(JObject.Parse(await response.Content.ReadAsStringAsync()));
            }
        }

        public async Task<MemeList> GetMemes(int count = 10)
        {
            if (count > 50) count = 50;
            string memeApiUrl = "https://meme-api.herokuapp.com/gimme";
            memeApiUrl += $"/{count}";
            HttpResponseMessage response = await httpClient.GetAsync(memeApiUrl);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Something has gone wrong, the API might be down. Please check at: {memeApiUrl}");
            }
            else
            {
                return new MemeList(JObject.Parse(await response.Content.ReadAsStringAsync()));
            }
        }
    }
}
