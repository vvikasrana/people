using System;
namespace PeopleApi.Core
{
    public class MongoDbContext : IMongoDbContext
    {
        public string PeopleCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMongoDbContext
    {
        string PeopleCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
