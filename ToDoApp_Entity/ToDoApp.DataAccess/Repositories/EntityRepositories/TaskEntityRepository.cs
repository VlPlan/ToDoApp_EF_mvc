using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDo.App.DataAccess.Repositories.EntityRepositories
{
    public class TaskEntityRepository : IRepository<_Task_>
    {
        private ToDoAppDbContext _context;
        public TaskEntityRepository(ToDoAppDbContext context)
        {

            _context = context;

        }
        public void DeleteById(int id)
        {
            _Task_ task = _context._Tasks.FirstOrDefault(x => x.Id == id);
            if (task != null)
                _context._Tasks.Remove(task);
            _context.SaveChanges();
        }

        public List<_Task_> GetAll()
        {
            return _context._Tasks.Include(x => x.SubTasks).ToList();
        }

        public _Task_ GetById(int id)
        {
            return _context._Tasks.Include(x => x.SubTasks).Include(x => x.User).FirstOrDefault(x => x.Id == id);
        }

        public int Insert(_Task_ entity)
        {
            _context._Tasks.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(_Task_ entity)
        {
            _Task_ task = _context._Tasks.FirstOrDefault(x => x.Id == entity.Id);
            if (task != null)
            {
                entity.Id = task.Id;
                _context._Tasks.Update(entity);
            }
        }
    }
}
