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
    }
}