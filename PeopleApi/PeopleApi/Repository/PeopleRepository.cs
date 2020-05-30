using System;
using System.Collections.Generic;
using PeopleApi.Model;
using MongoDB.Driver;
using PeopleApi.Core;

namespace PeopleApi.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly IMongoCollection<People> _people;

        public PeopleRepository(IMongoDbContext context)
        {
            var client = new MongoClient(context.ConnectionString);
            var database = client.GetDatabase(context.DatabaseName);

            _people = database.GetCollection<People>(context.PeopleCollectionName);
        }

        public void Add(People people)
        {
            _people.InsertOne(people);
        }

        public People Find(int personId)
        {
            return _people.Find<People>(p => p.PersonId == personId).FirstOrDefault();
        }

        public List<People> GetList()
        {
            return _people.Find<People>(p => true).ToList();
        }

        public void Update(int personId, People people)
        {
            _people.ReplaceOne(p => p.PersonId == personId, people);
        }
    }
}
