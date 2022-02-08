using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCrudOperationTemplate.Core
{
   public interface IUserServices
    {
        List<user> GetUsers();
        user GetUser(string user);
        user AddUser(user book);
        void DeleteUser(string user);
        user UpdateUser(user book);

    }
}
