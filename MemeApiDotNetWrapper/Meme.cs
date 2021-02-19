namespace MemeApiDotNetWrapper
{
    public class Meme
    {
        public string PostLink { get; set; }
        public string SubReddit { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool IsNsfw { get; set; }
        public bool IsSpoiler { get; set; }
        public string AuthorUsername { get; set; }
        public int Upvotes { get; set; }
        public PreviewList Previews { get; set; }

        protected internal Meme(dynamic response)
        {
            PostLink = response.postLink;
            SubReddit = response.subreddit;
            Title = response.title;
            ImageUrl = response.url;
            IsNsfw = response.nsfw;
            IsSpoiler = response.spoiler;
            AuthorUsername = response.author;
            Upvotes = response.ups;
            Previews = new PreviewList(response.preview.ToObject<string[]>());
        }

        public override string ToString()
        {
            return $"{{\n\tPostLink: {PostLink}\n\tSubReddit: {SubReddit}\n\tTitle: {Title}\n\tImageUrl: {ImageUrl}\n\tIsNsfw: {IsNsfw}\n\tIsSpoiler: {IsSpoiler}\n\tAuthorUsername: {AuthorUsername}\n\tUpvotes: {Upvotes}\n\tPreviews: {Previews}\n}}";
        }
    }

    public class PreviewList
    {
        public string PreviewURL108Width { get; set; }
        public string PreviewURL216Width { get; set; }
        public string PreviewURL320Width { get; set; }
        public string PreviewURL640Width { get; set; }
        public string PreviewURL960Width { get; set; }
        public string PreviewURL1080Width { get; set; }

        protected internal PreviewList(string[] preview)
        {
            if (preview.Length >= 1) PreviewURL108Width = preview[0];
            if (preview.Length >= 2) PreviewURL216Width = preview[1];
            if (preview.Length >= 3) PreviewURL320Width = preview[2];
            if (preview.Length >= 4) PreviewURL640Width = preview[3];
            if (preview.Length >= 5) PreviewURL960Width = preview[4];
            if (preview.Length >= 6) PreviewURL1080Width = preview[5];
        }

        public override string ToString()
        {
            return $"[{(string.IsNullOrEmpty(PreviewURL108Width) ? null : "\n\t\tPreviewURL108Width: " + PreviewURL108Width)}{(string.IsNullOrEmpty(PreviewURL216Width) ? null : "\n\t\tPreviewURL216Width: " + PreviewURL216Width)}{(string.IsNullOrEmpty(PreviewURL320Width) ? null : "\n\t\tPreviewURL320Width: " + PreviewURL320Width)}{(string.IsNullOrEmpty(PreviewURL640Width) ? null : "\n\t\tPreviewURL640Width: " + PreviewURL640Width)}{(string.IsNullOrEmpty(PreviewURL960Width) ? null : "\n\t\tPreviewURL960Width: " + PreviewURL960Width)}{(string.IsNullOrEmpty(PreviewURL1080Width) ? null : "\n\t\tPreviewURL1080Width: " + PreviewURL1080Width)}\n\t]";
        }
    }
}
