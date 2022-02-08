using MongoDB.Driver;
using MongodbCrudOperationTemplate.Core;
using System;
using System.Collections.Generic;

namespace MongoDbCrudOperationTemplate.Core
{
    public class UserServices : IUserServices
    {
        private readonly IMongoCollection<user> _users;

        public UserServices(IDbClient dbclient)
        {
          _users =   dbclient.GetUsersCollection();
        }
        public List<user> GetUsers()
        {
            return _users.Find(user => true).ToList();
        }

        public user AddUser(user user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void DeleteUser(string User)
        {
            _users.DeleteOne(user => user.User == User);
        }

        public user GetUser(string User) => _users.Find(user => user.User == User).First();

        public user UpdateUser(user user)
        {
            user test = GetUser(user.User);
            user.Id = test.Id;
            _users.ReplaceOne(b => b.User == user.User, user);
            return user;
        }




    }
}
