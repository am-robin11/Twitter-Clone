namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        
        private Guid _followerId;
        private Guid _followId;

        // Constructors

        // Parameterless constructor
        public Follow() : base(Guid.NewGuid())
        {
            
        }

        // Main constructor for creating a new follow relationship
        public Follow(Guid followerId, Guid followId) : this()
        {
            _followerId = followerId;
            _followId = followId;
        }

        // Properties

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowId
        {
            get { return _followId; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId {FollowerId}, FollowId {FollowId}";
        }
    }
}