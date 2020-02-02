using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;


namespace ToDoApp.Services.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        int AddNewUser(User entity);

    }
}
