namespace Domain.User
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string[] Permissions { get; set; } // TODO: Maybe replace with a UserPermissions array instead.
    }
}