using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace MemeApiDotNetWrapper.Tests
{
    public class MemeMachineTest
    {
        MemeMachine memeMachine;

        [SetUp]
        public void Setup()
        {
            memeMachine = new MemeMachine();
        }

        [Test]
        public async Task MemeReturnsSuccessfullyAsync()
        {
            var meme = await memeMachine.GetMemeAsync();
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public async Task MemeReturnsSuccessfullyWithNullParamsAsync()
        {
            var meme = await memeMachine.GetMemeAsync(null);
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public async Task MemeReturnsSuccessfullyWithBlankParamsAsync()
        {
            var meme = await memeMachine.GetMemeAsync("");
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public async Task MemeReturnsFromSpecificSubredditSuccessfullyAsync()
        {
            var meme = await memeMachine.GetMemeAsync("Otonokizaka");
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
        }

        [Test]
        public void MemeReturnsSuccessfully()
        {
            var meme = memeMachine.GetMeme();
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public void MemeReturnsSuccessfullyWithNullParams()
        {
            var meme = memeMachine.GetMeme(null);
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public void MemeReturnsSuccessfullyWithBlankParams()
        {
            var meme = memeMachine.GetMeme("");
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
        }

        [Test]
        public void MemeReturnsFromSpecificSubredditSuccessfully()
        {
            var meme = memeMachine.GetMeme("Otonokizaka");
            Assert.That(meme.AuthorUsername, Is.Not.Null);
            Assert.That(meme.ImageUrl, Is.Not.Null);
            Assert.That(meme.IsNsfw, Is.Not.Null);
            Assert.That(meme.IsSpoiler, Is.Not.Null);
            Assert.That(meme.PostLink, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.Not.Null);
            Assert.That(meme.Title, Is.Not.Null);
            Assert.That(meme.Upvotes, Is.Not.Null);
            Assert.That(meme.Previews, Is.Not.Null);
            Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
        }

        [Test]
        public async Task MultipleMemesReturnsSuccessfullyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync();
            Assert.That(memeList.Count, Is.EqualTo(10));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public async Task FiftyMemesReturnsSuccessfullyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync(50);
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public async Task MemesCappedAtFiftyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync(100);
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public async Task MultipleMemesReturnsFromSubredditSuccessfullyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync(subreddit: "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(10));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public async Task FiftyMemesReturnsFromSubredditSuccessfullyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync(50, "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public async Task SubredditSpecificMemesCappedAtFiftyAsync()
        {
            var memeList = await memeMachine.GetMemesAsync(100, "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void MultipleMemesReturnsSuccessfully()
        {
            var memeList = memeMachine.GetMemes();
            Assert.That(memeList.Count, Is.EqualTo(10));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void FiftyMemesReturnsSuccessfully()
        {
            var memeList = memeMachine.GetMemes(50);
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void MemesCappedAtFifty()
        {
            var memeList = memeMachine.GetMemes(100);
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.Not.Null);
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void MultipleMemesReturnsFromSubredditSuccessfully()
        {
            var memeList = memeMachine.GetMemes(subreddit: "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(10));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void FiftyMemesReturnsFromSubredditSuccessfully()
        {
            var memeList = memeMachine.GetMemes(50, "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }

        [Test]
        public void SubredditSpecificMemesCappedAtFifty()
        {
            var memeList = memeMachine.GetMemes(100, "Otonokizaka");
            Assert.That(memeList.Count, Is.EqualTo(50));
            Assert.That(memeList.Memes, Is.Not.Null);
            foreach (var meme in memeList.Memes)
            {
                Assert.That(meme.AuthorUsername, Is.Not.Null);
                Assert.That(meme.ImageUrl, Is.Not.Null);
                Assert.That(meme.IsNsfw, Is.Not.Null);
                Assert.That(meme.IsSpoiler, Is.Not.Null);
                Assert.That(meme.PostLink, Is.Not.Null);
                Assert.That(meme.SubReddit, Is.EqualTo("Otonokizaka"));
                Assert.That(meme.Title, Is.Not.Null);
                Assert.That(meme.Upvotes, Is.Not.Null);
                Assert.That(meme.Previews, Is.Not.Null);
            }
        }
    }
}