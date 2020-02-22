namespace OpenStore365.Serverless.Auth
{
    public class User
    {
        public User(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        public string Id { get; }
        public string DisplayName { get; }
    }
}
