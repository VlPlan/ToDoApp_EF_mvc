using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;
using System.Linq;


namespace ToDo.App.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteById(int id)
        {
            User user = CacheDb.Users.FirstOrDefault(x => x.Id == id);
            if (user != null) CacheDb.Users.Remove(user);
        }

        public int Insert(User entity)
        {
            CacheDb.UserId++;
            entity.Id = CacheDb.UserId;
            CacheDb.Users.Add(entity);
            return entity.Id;
        }

        public User GetById(int id)
        {
            return CacheDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetAll()
        {
            return CacheDb.Users;
        }


        public void Update(User entity)
        {
            User user = CacheDb.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                int index = CacheDb.Users.IndexOf(user);
                CacheDb.Users[index] = entity;
            }
        }

    }
}
