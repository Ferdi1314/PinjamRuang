using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPinjamRuang.Models
{
    public class History
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement]
        public string date { get; set; }
        [BsonElement]
        public string name { get; set; }
        [BsonElement]
        public string facility { get; set; }
        [BsonElement]
        public string eventName { get; set; }
        [BsonElement]
        public string pic { get; set; }
        [BsonElement]
        public string contact { get; set; }
        [BsonElement]
        public string nim { get; set; }
        [BsonElement]
        public int capacity { get; set; }
        [BsonElement]
        public int time { get; set; }
        [BsonElement]
        public int session { get; set; }
    }
}
