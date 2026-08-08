namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _bio;
        private string _profilePictureUrl;
        private string _passwordHash;
        private DateTime _createdAt;
        private bool _isActive;

        // Parameterless constructor

        public User()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _isActive = true;
        }

        // Constructor
        public User(string firstName, string lastName, string username, string email, string passwordHash) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _passwordHash = passwordHash;
        }

        //Properties

        public Guid Id
        {
            get { return _id; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public string ProfilePictureUrl
        {
            get { return _profilePictureUrl; }
            set { _profilePictureUrl = value; }
        }

        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        //Domain Methods for Profile Management (Story 1)

        public void UpdateProfile(string firstName, string lastName, string bio, string profilePictureUrl)
        {
            _firstName = firstName;
            _lastName = lastName;
            _bio = bio;
            _profilePictureUrl = profilePictureUrl;
        }

        public void DeactivateAccount()
        {
            _isActive = false;
        }

        public void ReactivateAccount()
        {
            _isActive = true;
        }
    }
}
