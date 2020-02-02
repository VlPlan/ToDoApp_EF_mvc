using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;
using System.Linq;


namespace ToDo.App.DataAccess.Repositories
{
    public class TaskRepository : IRepository<_Task_>
    {

        public void DeleteById(int id)
        {
            _Task_ task = CacheDb._Tasks.FirstOrDefault(x => x.Id == id);
            if (task != null) CacheDb._Tasks.Remove(task);
        }

        public int Insert(_Task_ entity)
        {
            CacheDb._Task_Id++;
            entity.Id = CacheDb._Task_Id;
            CacheDb._Tasks.Add(entity);
            return entity.Id;
        }

        public _Task_ GetById(int id)
        {
            return CacheDb._Tasks.SingleOrDefault(x => x.Id == id);
        }

        public List<_Task_> GetAll()
        {
            return CacheDb._Tasks;
        }


        public void Update(_Task_ entity)
        {
            _Task_ task = CacheDb._Tasks.FirstOrDefault(x => x.Id == entity.Id);
            if (task != null)
            {
                int index = CacheDb._Tasks.IndexOf(task);
                CacheDb._Tasks[index] = entity;
            }
        }
    }
}
