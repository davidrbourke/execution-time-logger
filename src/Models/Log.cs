using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ExecutionTimeLogger.Models
{
    public class ExecutionTimeLogger
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string  Id { get; set; }
        public string EventName { get;set;}
        public IEnumerable<Event> Events { get; set; }
    }
}