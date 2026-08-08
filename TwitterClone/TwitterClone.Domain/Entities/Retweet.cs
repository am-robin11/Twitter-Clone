namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _retweetedAt;

        // Constructors

        // Parameterless constructor
        public Retweet()
        {
            
        }

        // Main constructor for creating a new retweet
        public Retweet(Guid userId, Guid tweetId) : this()
        {
            _userId = userId;
            _tweetId = tweetId;
            _retweetedAt = DateTime.UtcNow;
        }

        // Properties

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
        }
    }
}