namespace TwitterClone.Domain.Entities
{
    public sealed class RetweetNotification : Notification
    {
        private readonly Guid _retweetedByUserId;

        public RetweetNotification(Guid retweetedByUserId) : base("Retweet")
        {
            _retweetedByUserId = retweetedByUserId;
        }

        public Guid RetweetedByUserId => _retweetedByUserId;

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RetweetedByUserId: {RetweetedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {RetweetedByUserId} retweeted your post";
        }
    }
}