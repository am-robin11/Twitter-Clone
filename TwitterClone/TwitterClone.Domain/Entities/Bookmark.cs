namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {

        private Guid _userId;
        private Guid _tweetId;
        private DateTime _bookmarkedAt;

        // Parameterless constructor
        public Bookmark() : base(Guid.NewGuid())
        {

        }

        public Bookmark(Guid userId, Guid tweetId) : this()
        {
            _userId = userId;
            _tweetId = tweetId;
            
        }

        // Properties

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }   
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }   
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId {UserId}, TweetId {TweetId}";
        }

    }
}
