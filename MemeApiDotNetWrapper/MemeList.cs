using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemeApiDotNetWrapper
{
    public class MemeList
    {
        public int Count { get; set; }
        public List<Meme> Memes { get; set; }

        protected internal MemeList(dynamic response)
        {
            Count = response.count;
            var memeList = response.memes.ToObject<List<JObject>>();
            Memes = new List<Meme>();
            foreach (var meme in memeList)
            {
                Memes.Add(new Meme(meme));
            }
        }
    }
}
