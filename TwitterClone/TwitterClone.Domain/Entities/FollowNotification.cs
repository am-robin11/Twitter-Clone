namespace TwitterClone.Domain.Entities
{
    public sealed class FollowNotification : Notification
    {
        private readonly Guid _followerId;

        public FollowNotification(Guid followerId) : base("Follow")
        {
            _followerId = followerId;
        }

        public Guid FollowerId => _followerId;

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId: {FollowerId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {FollowerId} started following you";
        }
    }
}