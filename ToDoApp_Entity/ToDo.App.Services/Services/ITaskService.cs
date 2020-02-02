using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;

namespace ToDoApp.Services.Services
{
    public interface ITaskService
    {
        List<_Task_> GetAllTasks();
        _Task_ GetTaskById(int id);
        void AddNewTask(_Task_ task);
        int GetNumberOfTasks();
        _Task_ GetLastTask();
        void RemoveTask(_Task_ task);
        void EditTask(_Task_ task);

    }
}

