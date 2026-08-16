
namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUserId) : base("Comment")
        {
            CommentByUserId = commentByUserId;
        }

        public Guid CommentByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, CommentByUserId: {CommentByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommentByUserId} commented on your post";
        }
    }
}
