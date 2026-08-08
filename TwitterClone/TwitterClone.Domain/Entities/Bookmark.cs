namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _bookmarkedAt;

        // Constructors

        // Parameterless constructor
        public Bookmark()
        {
            
        }

        // Main constructor for creating a new bookmark
        public Bookmark(Guid userId, Guid tweetId) : this()
        {
            _userId = userId;
            _tweetId = tweetId;
            _bookmarkedAt = DateTime.UtcNow;
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

        public DateTime BookmarkedAt
        {
            get { return _bookmarkedAt; }
        }
    }
}
