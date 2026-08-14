namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {

        private Guid _userId;
        private Guid _tweetId;
        // private string _quoteContent;


        // Constructors

        // Parameterless constructor
        public Retweet() : base(Guid.NewGuid())
        {

        }

        // Main constructor for creating a new retweet
        public Retweet(Guid userId, Guid tweetId) : this()
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

        //public bool IsQuoteTweet => !string.IsNullOrWhiteSpace(_quoteContent);

        // Domain method to update the quote content (e.g., if the user edits the quote)
        //public void SetQuoteContent(string quoteContent)
        //{
        //    if (quoteContent != null && quoteContent.Length > 280)
        //        throw new ArgumentException("Quote content cannot exceed 280 characters.");

        //    _quoteContent = quoteContent?.Trim(); // null if empty/whitespace
        //}

        public DateTime RetweetedAt => CreatedAt;

        public override string DescribeRecord()
        {
            var baseDescription = base.DescribeRecord();
            // var quoteInfo = IsQuoteTweet ? $", Quote: \"{_quoteContent}\"" : " (simple retweet)";
            return $"{baseDescription}, UserId: {UserId}, TweetId: {TweetId}, ReTweetedAt {RetweetedAt}";
        }


    }
}