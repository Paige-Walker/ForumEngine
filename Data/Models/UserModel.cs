namespace Data.Models
{
    using System;

    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string[] Permissions { get; set; }

    }
}