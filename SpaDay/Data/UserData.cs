using SpaDay.Models;
using System.Collections.Generic;

namespace SpaDay.Data
{
    public class UserData
    {
        static private Dictionary<int, User> Users = new Dictionary<int, User>();

        public static IEnumerable<User> GetAll()
        {
            return Users.Values;
        }

        public static void Add(User newUser)
        {
            Users.Add(newUser.Id, newUser);
        }

        public static void Remove(int id)
        {
            Users.Remove(id);
        }

        public static UserData GetById(int id)
        {
            return Users[id];
        }
    }
}
