namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        // Constructors

        // Parameterless constructor
        public Like()
        {
            
        }

        // Main constructor for creating a new like
        public Like(Guid userId, Guid tweetId) : this()
        {
            _userId = userId;
            _tweetId = tweetId;
            _likedAt = DateTime.UtcNow;
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

        public DateTime LikedAt
        {
            get { return _likedAt; }
        }
    }
}