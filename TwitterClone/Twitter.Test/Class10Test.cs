using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10Test
    {
        public void Run()
        {
            var tweet = new Tweet("My First Tweet!");
            
            // Additional Comment
            // var tweet = new Tweet(Guid.NewGuid(),"My First Tweet!");
            // Wrote this line to test that it also calls the second constructor
            
            tweet.AddContent("Just Content");


            // An example of upcasting
            // ILikable likableTweet = new Tweet("This is another Tweet");

            Tweet likableTweet = new Tweet("This is another Tweet");

            Console.WriteLine(likableTweet.CanBeLiked());

            var maxTweetLength = Tweet.MaxContentLength;
        }
    }
}
