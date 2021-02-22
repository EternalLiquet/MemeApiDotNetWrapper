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
        public async Task MemeReturnsSuccessfully()
        {
            var meme = await memeMachine.GetMeme();
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
        public async Task MemeReturnsSuccessfullyWithNullParams()
        {
            var meme = await memeMachine.GetMeme(null);
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
        public async Task MemeReturnsSuccessfullyWithBlankParams()
        {
            var meme = await memeMachine.GetMeme("");
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
        public async Task MemeReturnsFromSpecificSubredditSuccessfully()
        {
            var meme = await memeMachine.GetMeme("Otonokizaka");
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
        public async Task MultipleMemesReturnsSuccessfully()
        {
            var memeList = await memeMachine.GetMemes();
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
        public async Task FiftyMemesReturnsSuccessfully()
        {
            var memeList = await memeMachine.GetMemes(50);
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
        public async Task MemesCappedAtFifty()
        {
            var memeList = await memeMachine.GetMemes(100);
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
    }
}