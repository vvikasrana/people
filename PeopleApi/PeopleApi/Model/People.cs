using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PeopleApi.Model
{
    public class People
    {
        public People()
        {
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int PersonId { get; set; }

        [BsonElement("Name")]
        public string PersonName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
