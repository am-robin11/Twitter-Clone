namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {

        private Guid _id;
        private Guid _authorId;
        private string _content;
        private DateTime _createdAt;
        private DateTime? _updatedAt;
        private bool _isDeleted;

        // Parameterless constructor
        public Tweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _isDeleted = false;
        }

        // Main constructor for creating a new tweet (Story 2 - "post")
        public Tweet(Guid authorId, string content) : this()
        {
            _authorId = authorId;
            AddContent(content);
        }

        //Properties

        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content { get; private set; }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime? UpdatedAt
        {
            get { return _updatedAt; }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            private set { _isDeleted = value; }
        }

        public void AddContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Content cannot be empty or whitespace.");
            }
            if (content.Length > 280)
            {
                throw new ArgumentException("Content cannot exceed 280 characters.");
            }
            Content = content;
            _updatedAt = DateTime.UtcNow;
        }

        //New methods for Story 2 (delete & restore)

        public void SoftDelete()
        {
            _isDeleted = true;
            _updatedAt = DateTime.UtcNow;
        }

        public void Restore()
        {
            _isDeleted = false;
            _updatedAt = DateTime.UtcNow;
        }
    }
}
