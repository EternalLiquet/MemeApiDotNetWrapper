using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemeApiDotNetWrapper
{
    public class MemeMachine
    {
        private const string memeApiBaseUrl = "https://meme-api.com/gimme";
        private static HttpClient httpClient;

        public MemeMachine()
        {
            httpClient = new HttpClient();
        }

        public async Task<Meme> GetMemeAsync(string subreddit = null)
        {
            string memeApiUrl = memeApiBaseUrl;
            if (!string.IsNullOrEmpty(subreddit))
            {
                memeApiUrl += $"/{subreddit}";
            }

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

        public Meme GetMeme(string subreddit = null)
        {
            string memeApiUrl = memeApiBaseUrl;
            if (!string.IsNullOrEmpty(subreddit))
            {
                memeApiUrl += $"/{subreddit}";
            }

            HttpResponseMessage response = httpClient.GetAsync(memeApiUrl).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Something has gone wrong, the API might be down. Please check at: {memeApiUrl}");
            }
            else
            {
                return new Meme(JObject.Parse(response.Content.ReadAsStringAsync().Result));
            }
        }

        public async Task<MemeList> GetMemesAsync(int count = 10, string subreddit = null)
        {
            if (count > 50)
            {
                count = 50;
            }

            string memeApiUrl = memeApiBaseUrl;
            if (!string.IsNullOrEmpty(subreddit))
            {
                memeApiUrl += $"/{subreddit}";
            }

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

        public MemeList GetMemes(int count = 10, string subreddit = null)
        {
            if (count > 50)
            {
                count = 50;
            }

            string memeApiUrl = memeApiBaseUrl;
            if (!string.IsNullOrEmpty(subreddit))
            {
                memeApiUrl += $"/{subreddit}";
            }

            memeApiUrl += $"/{count}";
            HttpResponseMessage response = httpClient.GetAsync(memeApiUrl).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Something has gone wrong, the API might be down. Please check at: {memeApiUrl}");
            }
            else
            {
                return new MemeList(JObject.Parse(response.Content.ReadAsStringAsync().Result));
            }
        }
    }
}
