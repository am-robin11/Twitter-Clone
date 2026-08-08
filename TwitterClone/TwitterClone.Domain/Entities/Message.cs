namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;

        // Constructors

        // Parameterless constructor
        public Message()
        {
            _id = Guid.NewGuid();
            _sentAt = DateTime.UtcNow;
            _isRead = false;
        }

        // Main constructor for sending a new message
        public Message(Guid senderId, Guid receiverId, string content) : this()
        {
            _senderId = senderId;
            _receiverId = receiverId;
            SetContent(content);
        }

        // Properties

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        // Auto-property with private setter
        public string Content { get; private set; }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            private set { _isRead = value; }
        }

        // Domain Methods

        // Validates and sets the message content
        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Content cannot be empty or whitespace.");
            }
            if (content.Length > 10000) // Twitter DM limit is 10,000 characters
            {
                throw new ArgumentException("Content cannot exceed 10000 characters.");
            }
            Content = content;
        }

        // Marks the message as read (Story 8 - real-time messages)
        public void MarkAsRead()
        {
            _isRead = true;
        }
    }
}