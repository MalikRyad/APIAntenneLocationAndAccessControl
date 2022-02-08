using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCrudOperationTemplate.Core
{
   public class user
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string User { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public string Sexe { get; set; }
    }
}
