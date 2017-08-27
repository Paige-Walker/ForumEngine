namespace Domain.User
{
    using System;

    using Domain.Generic;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User : IEntity<Guid>
    {
        public ObjectId MongoId { get; set; }
        [BsonElement("UserId")]
        public Guid Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Permissions")]
        public string[] Permissions { get; set; } // TODO: Maybe replace with a UserPermissions array instead.
    }
}