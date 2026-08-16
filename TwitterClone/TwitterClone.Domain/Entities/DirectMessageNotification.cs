namespace TwitterClone.Domain.Entities
{
    public sealed class DirectMessageNotification : Notification
    {
        private readonly Guid _senderId;

        public DirectMessageNotification(Guid senderId) : base("DirectMessage")
        {
            _senderId = senderId;
        }

        public Guid SenderId => _senderId;

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, SenderId: {SenderId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {SenderId} sent you a direct message";
        }
    }
}