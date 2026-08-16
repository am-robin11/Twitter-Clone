
// using TwitterClone.Domain;
using TwitterClone.Domain.Entities;

var notifications= new List<Notification>()
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new FollowNotification(Guid.NewGuid()),
    new RetweetNotification(Guid.NewGuid()),
    new DirectMessageNotification(Guid.NewGuid()),
    new SystemNotification()
};

foreach(var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}
