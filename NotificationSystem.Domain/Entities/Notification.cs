using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NotificationSystem.Domain.Enums;

namespace NotificationSystem.Domain.Entities
{
    public class Notification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Channel")]
        [BsonRepresentation(BsonType.String)]
        public NotificationChannel Channel { get; set; }

        [BsonElement("Recipient")]
        public string Recipient { get; set; } = string.Empty;

        [BsonElement("Priority")]
        [BsonRepresentation(BsonType.String)]
        public NotificationPriority Priority { get; set; }

        [BsonElement("Status")]
        [BsonRepresentation(BsonType.String)]
        public NotificationStatus Status { get; set; }

        [BsonElement("Retries")]
        public int Retries { get; set; } = 0;

        [BsonElement("CreateAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

        [BsonElement("UpdatedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? UpdatedAt { get; set; }
    }
}