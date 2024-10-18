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

        private string Email { get; }
        private string Username { get; set; }
        private string PasswordHash { get; set; }
        private PermissionLevel PermissionLevel { get; set; }
    }

    public enum PermissionLevel
    {
        User,
        Moderator,
        Administrator
    }
}
