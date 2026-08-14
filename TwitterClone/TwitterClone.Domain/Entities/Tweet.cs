namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {


        private Guid _authorId;
        private string _content;
        private bool _isDeleted;

        // Parameterless constructor
        public Tweet(Guid authorId, string content) : base(Guid.NewGuid())
        {
            _authorId = authorId;
            SetContent(content);
            _isDeleted = false;
        }

        //Properties

        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }

        public string Content
        {
            get { return _content; }
            private set { _content = value; }
        }

        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be empty or whitespace.");
            if (content.Length > 280)
                throw new ArgumentException("Content cannot exceed 280 characters.");
            _content = content;
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            private set { _isDeleted = value; }
        }

        public DateTime TweetedAt => CreatedAt;

        public override string DescribeRecord()
        {
            var baseDescription = base.DescribeRecord();
            return $"{baseDescription}, AuthorId: {AuthorId}, Content {Content}, TweetedAt {TweetedAt}";
        }

    }
}
