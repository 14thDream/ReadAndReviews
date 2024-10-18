namespace Models
{
    public class Account
    {
        public Account(string email, string username, string passwordHash, PermissionLevel permissionLevel)
        {
            Email = email;
            Username = username;
            PasswordHash = passwordHash;
            PermissionLevel = permissionLevel;
        }

        public Account(string email, string username, string passwordHash) : this(email, username, passwordHash, PermissionLevel.User) { }

        public string Email { get; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public PermissionLevel PermissionLevel { get; set; }
    }

    public enum PermissionLevel
    {
        User,
        Moderator,
        Administrator
    }
}
