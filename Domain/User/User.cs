namespace Domain.User
{
    using System;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User
    {
        public ObjectId Id { get; set; }
        [BsonElement("UserId")]
        public Guid UserId { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Permissions")]
        public string[] Permissions { get; set; } // TODO: Maybe replace with a UserPermissions array instead.
    }
}