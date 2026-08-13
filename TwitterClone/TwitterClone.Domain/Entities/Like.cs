namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;

        // Constructors

        // Parameterless constructor
        public Like() : base(Guid.NewGuid())
        {

        }

        // Main constructor for creating a new like
        public Like(Guid userId, Guid tweetId) : this()
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
        }

        public DateTime LikedAt => CreatedAt;

        public override string DescribeRecord()
        {
            var baseDescription = base.DescribeRecord();
            return $"{baseDescription}, UserId: {UserId}, TweetId: {TweetId}, LikedAt {LikedAt}";
        }
    }
}