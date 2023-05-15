using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using NLog;
using PortalTransparenciaDeps.Core.ServerSettings;
using System;

namespace PortalTransparenciaDeps.Infrastructure.Storage
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly ILogger _logger;

        public MongoContext()
        {
            _logger = LogManager.GetCurrentClassLogger();

            var settings = new NoSqlDatabaseSettings();

            BsonSerializer.RegisterSerializer(typeof(DateTime), new DepsMongoDBDateTimeSerializer());

            var mongoConnectionUrl = new MongoUrl(settings.ConnectionString);

            var mongoClientSettings = MongoClientSettings.FromUrl(mongoConnectionUrl);

            mongoClientSettings.ClusterConfigurator = cb =>
            {
                cb.Subscribe<CommandStartedEvent>(e =>
                {
#if DEBUG
                    _logger.Debug($"{e.CommandName} - {e.Command}");
#endif
                });
            };

            _client = new MongoClient(mongoClientSettings);
            _database = _client.GetDatabase(settings.DatabaseName);
        }

        public IMongoClient Client => _client;

        public IMongoDatabase DatabaseStorage => _database;
    }

    public class DepsMongoDBDateTimeSerializer : DateTimeSerializer
    {
        public override DateTime Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            return base.Deserialize(context, args).ToLocalTime();
        }
    }
}
