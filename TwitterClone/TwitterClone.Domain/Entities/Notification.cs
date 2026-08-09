namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        // Fields

        private Guid _id;
        private Guid _userId;
        private string _type;       
        private string _message;    
        private bool _isRead;
        private DateTime _createdAt;

        // Constructors

        // Parameterless constructor
        public Notification()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _isRead = false;
        }

        // Main constructor for creating a new notification
        public Notification(Guid userId, string type, string message) : this()
        {
            _userId = userId;
            _type = type;
            _message = message;
        }

        // Properties

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            private set { _isRead = value; } // Private to enforce using MarkAsRead()
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        // Domain Methods

        // Marks the notification as read (Story 5 - real-time notifications)
        public void MarkAsRead()
        {
            _isRead = true;
        }
    }
}