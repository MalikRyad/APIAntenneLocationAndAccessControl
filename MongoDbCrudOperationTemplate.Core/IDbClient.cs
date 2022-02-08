using MongoDB.Driver;
using MongoDbCrudOperationTemplate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongodbCrudOperationTemplate.Core
{
    public interface IDbClient
    {
        IMongoCollection<user> GetUsersCollection();
    }
}
