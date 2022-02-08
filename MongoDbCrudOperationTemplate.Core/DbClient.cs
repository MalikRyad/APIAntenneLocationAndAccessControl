using MongoDB.Driver;
using MongodbCrudOperationTemplate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;


namespace MongoDbCrudOperationTemplate.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<user> _users;

        public DbClient(IOptions<mylibDbConfig> configue)
        {
            var client = new MongoClient(configue.Value.Connection_String);
            var database = client.GetDatabase(configue.Value.Database_Name);
            
               _users = database.GetCollection<user>(configue.Value.mylib_Collection_Name);

        }

        public IMongoCollection<user> GetUsersCollection()
        {
            return _users;
        }
    }
}

