using MongoDB.Driver;
using NotificationSystem.Domain.Entities;

namespace NotificationSystem.Infra.Data
{
    public class MongoDbInitializer
    {
        private readonly IMongoDatabase _database;

        public MongoDbInitializer(IMongoDatabase database)
        {
            _database = database;
        }

        public void Initialize()
        {
            var notificationCollection = _database.GetCollection<Notification>("Notifications");
            var notificationIndexKeys = Builders<Notification>.IndexKeys.Ascending(n => n.Id);
            notificationCollection.Indexes.CreateOne(new CreateIndexModel<Notification>(notificationIndexKeys));

            var templateCollection = _database.GetCollection<Template>("Templates");
            var templateIndexKeys = Builders<Template>.IndexKeys.Ascending(t => t.Id);
            templateCollection.Indexes.CreateOne(new CreateIndexModel<Template>(templateIndexKeys));
        }
    }
}