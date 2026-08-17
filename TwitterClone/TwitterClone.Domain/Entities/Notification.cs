namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        // Fields

        
        private Guid _userId;
        private string _type;       
        private string _message;    
        private bool _isRead;
        

        // Constructors

        // Parameterless constructor
        public Notification(string notificationtype) : base(Guid.NewGuid())
        {
            _isRead = false;
            _type = notificationtype;
        }

        // Properties

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        protected string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            private set { _isRead = value; } // Private to enforce using MarkAsRead()
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}";
        }

        public string GetNotificationInfo()
        {
            return $"UserId: {_userId}, NotificationType: {_type}";
        }

        public abstract string GetMessage();

        // Domain Methods

            // Marks the notification as read (Story 5 - real-time notifications)
        public void MarkAsRead()
        {
            _isRead = true;
        }
    }
}