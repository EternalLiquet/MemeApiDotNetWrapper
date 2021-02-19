# MemeApiDotNetWrapper

Does your application make use of random memes from Reddit? If this is the case, you might use this [API](https://github.com/D3vd/Meme_Api) to get your memes. That's fine and dandy, but what if you don't want to write your own implementation of it? That's where this wrapper comes in. Call one function and get your meme easily! Original API found here: https://github.com/D3vd/Meme_Api

If you find this library particularly useful/helpful please consider supporting me:  
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E82Y3GS)

### Usage Example

```cs
using System;
using MemeApiDotNetWrapper;

namespace Example
{
    public class CoolClass
    {
        public async void GetMeme()
        {
            MemeMachine memeMachine = new MemeMachine();
            var meme = await memeMachine.GetMeme();
            Console.WriteLine(meme.PostLink); // "https://redd.it/jiovfz"
            Console.WriteLine(meme.SubReddit); // "dankmemes"
            Console.WriteLine(meme.Title); // "*leaves call*"
            Console.WriteLine(meme.ImageUrl); // "https://i.redd.it/f7ibqp1dmiv51.gif"
            Console.WriteLine(meme.IsNsfw); // false
            Console.WriteLine(meme.IsSpoiler); // false
            Console.WriteLine(meme.AuthorUsername); // "Spartan-Yeet"
            Console.WriteLine(meme.Upvotes); // 3363
            Console.WriteLine(meme.Preview); /* [
                                                    PreviewURL108Width: "https://preview.redd.it/f7ibqp1dmiv51.gif?width=108&crop=smart&format=png8&s=02b12609100c14f55c31fe046f413a9415804d62",
                                                    PreviewURL216Width: "https://preview.redd.it/f7ibqp1dmiv51.gif?width=216&crop=smart&format=png8&s=8da35457641a045e88e42a25eca64c14a6759f82",
                                                    PreviewURL320Width: "https://preview.redd.it/f7ibqp1dmiv51.gif?width=320&crop=smart&format=png8&s=f2250b007b8252c7063b8580c2aa72c5741766ae",
                                                    PreviewURL640Width: "https://preview.redd.it/f7ibqp1dmiv51.gif?width=640&crop=smart&format=png8&s=6cd99df5e58c976bc115bd080a1e6afdbd0d71e7"
                                                ]
                                                *Additional Note: Previews go up to 1080 Width, depending on availability.
                                            */
        }
    }
}
```

### Resulting Class Structure:

```javascript
Result: (object){
    PostLink: string //returns the link to the reddit post
    SubReddit: string //returns the subreddit that the meme came from
    Title: string //returns the title of the original post
    ImageUrl: string //returns the direct link to the meme
    IsNsfw: boolean //returns whether or not the post was marked as NSFW on reddit
    IsSpoiler: boolean //returns whether or not the post was marked as a spoiler on reddit
    AuthorUsername: string //returns the username of the original poster
    Upvotes: number //returns the amount of upvotes the post receivied
    Preview: [ //returns a list of preview links in various sizes
        PreviewURL108Width: string //returns a direct link to a preview of the meme with the width of 108 pixels
        PreviewURL216Width: string //returns a direct link to a preview of the meme with the width of 216 pixels
        PreviewURL320Width: string //returns a direct link to a preview of the meme with the width of 320 pixels
        PreviewURL640Width: string //returns a direct link to a preview of the meme with the width of 640 pixels
        PreviewURL960Width: string //returns a direct link to a preview of the meme with the width of 960 pixels
        PreviewURL1080Width: string //returns a direct link to a preview of the meme with the width of 1080 pixels
    ]
}
```

### Benefits Of Using This Library:

Boils down the process of writing the implementation for the Random Reddit Meme Api to 3 lines. Import. Instantiate. Meme.

### As a side note, if you would like to support or contribute to the development of the library:

- Feel free to fork the repo and PR back any additions
- Contact me at aldmnatividad@gmail.com for any suggestions
- Donate to my [Ko-fi here](https://ko-fi.com/liquet) (I do this in my free time so any donation you can give helps me develop more things like this!)
