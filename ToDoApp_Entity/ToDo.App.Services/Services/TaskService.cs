using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;
using ToDo.App.DataAccess.Repositories;
using ToDo.App.Services;




namespace ToDoApp.Services.Services
{
    public class TaskService : ITaskService
    {

        private IRepository<_Task_> _taskRepository;
        public TaskService(IRepository<_Task_> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddNewTask(_Task_ task)
        {
            _taskRepository.Insert(task);
        }

        public List<_Task_> GetAllTasks()
        {
            return _taskRepository.GetAll();
        }

        public _Task_ GetLastTask()
        {
            List<_Task_> tasks = _taskRepository.GetAll();
            return tasks[tasks.Count - 1];
        }

        public int GetNumberOfTasks()
        {
            return _taskRepository.GetAll().Count;
        }

        public _Task_ GetTaskById(int id)
        {
            return _taskRepository.GetById(id);
        }

        public void RemoveTask(_Task_ task)
        {
            _taskRepository.GetAll().Remove(task);
        }

        public void EditTask(_Task_ task)
        {
            _taskRepository.Update(task);

        }

    }
}
