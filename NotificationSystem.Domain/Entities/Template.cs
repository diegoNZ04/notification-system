using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NotificationSystem.Domain.Entities
{
    public class Template
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("Content")]
        public string Content { get; set; } = string.Empty;

        [BsonElement("CreateAt")]
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }
}