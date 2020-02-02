using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.App.Domain;
using ToDo.App.WebApp.Models;
using ToDo.App.DataAccess;
using ToDo.App.DataAccess.Repositories;


namespace ToDo.App.Remastered.WebApp.Controllers
{

    public class TaskController : Controller
    {
        //private static IRepository<User> _userService;
        private static IList<_Task_> _allTasks;
        private static IList<User> Users;


        static TaskController()
        {

              Users = new List<User>()
            {
             new User()
            {
                Id = 1,
                Firstname = "Slave",
                Lastname = "Konev",
                Age = 33,
                AverageFreeTime = 4,

            },

            new User()
            {
                Id = 2,
                Firstname = "Marina",
                Lastname = "Mihajlova",
                Age = 26,
                AverageFreeTime = 2,

            },

            new User()
            {
                Id = 3,
                Firstname = "Igor",
                Lastname = "Terzic",
                Age = 30,
                AverageFreeTime = 1,
            }
            };

                _allTasks = new List<_Task_>()
           {
            new _Task_()
            {
                Id = 1,
                User = Users[0],
                Title = "My wednesday activities",
                Description = "After Work tasks",
                PriorityLevel = PriorityLevel.medium,
                Status = Status.NotDone,
                Type = Domain.Type.Personal,
                SubTasks = new List<SubTask>()
                {
                    new SubTask()
                    {
                        Id = 1,
                        Title = "Go to supermarket",
                        Description = "shopping",
                        Status = Status.NotDone
                     },
                    new SubTask()
                    {
                        Id = 2,
                        Title = "Gym",
                        Description = "sport",
                        Status = Status.NotDone
                    },
                }
            },

                 new _Task_()
            {
                Id = 2,
                User = Users[1],
                Title = "Check Emails",
                Description = "check recieved emails from our buyers",
                PriorityLevel = PriorityLevel.important,
                Status = Status.NotDone,
                Type = Domain.Type.Work,
               SubTasks = new List<SubTask>()
                {
                    new SubTask()
                    {
                        Id = 3,
                        Title = "Check my colleague email",
                        Description = "check colleague's mail while he is on holiday",
                        Status = Status.NotDone
                     },
               }
            },


            new _Task_()
            {
                Id = 3,
                User = Users[2],
                Title = "Training",
                Description = "Gym training on Saturday",
                PriorityLevel = PriorityLevel.notImportant,
                Status = Status.NotDone,
                Type = Domain.Type.Hobby,
                SubTasks = new List<SubTask>()
                {
                    new SubTask()
                   {
                        Title = "Gym membership",
                        Description = "pay membership for Gym",
                        Status = Status.NotDone
                   },
                }
            },

            new _Task_()
            {
                Id = 4,
                User = Users[2],
                Title = "Work activities",
                Description = "Meeting with clients at 9am",
                PriorityLevel = PriorityLevel.important,
                Status = Status.NotDone,
                Type = Domain.Type.Work,
                SubTasks = new List<SubTask>()
                {
                    new SubTask()
                   {
                        Title = "Agreement",
                        Description = "Sign new agreement for cooperation for 2019",
                        Status = Status.NotDone
                   },
                }
            }

            };
            }

        //public TaskController(IRepository<User> userService, IRepository<_Task_> taskService)
        //{
        //    _userService = userService;
        //    _taskService = taskService;
        //}

        [Route("Statistics")]
        public IActionResult Statistics()
        {

            ViewBag.Title = "Tasks Statistics page";


            List<TasksViewModel> viewTasks = new List<TasksViewModel>();


            foreach (var task in _allTasks)
            {
                viewTasks.Add(new TasksViewModel()
                {
                    Id = task.Id,
                    FirstName = task.User.Firstname,
                    LastName = task.User.Lastname,
                    Title = task.Title,
                    Description = task.Description,
                    Status = task.Status

                });

            }
            ViewTaskModel model = new ViewTaskModel()
            {
                MyTasks = viewTasks
            };

            return View(model);

        }

        [Route("UnfinishedTasks")]
        public IActionResult UnfinishedTasks()
        {

            List<TasksViewModel> viewTasks = new List<TasksViewModel>();
            

            foreach (var task in _allTasks)
            {
                if (task.Status == Status.NotDone)
                {
                    viewTasks.Add(new TasksViewModel()
                    {
                        Id = task.Id,
                        FirstName = task.User.Firstname,
                        LastName = task.User.Lastname,
                        Title = task.Title,
                        Description = task.Description,
                        Status = task.Status

                    });
                }
            }
            ViewTaskModel model = new ViewTaskModel()
            {
                MyTasks = viewTasks
            };

            return View(model);

        }

        [Route("FinishedTasks")]
        public IActionResult FinishedTasks()
        {


            List<TasksViewModel> viewTasks = new List<TasksViewModel>();
        

            foreach (var task in _allTasks)
            {
                if (task.Status == Status.Done)
                {
                    viewTasks.Add(new TasksViewModel()
                    {
                        Id = task.Id,
                        FirstName = task.User.Firstname,
                        LastName = task.User.Lastname,
                        Title = task.Title,
                        Description = task.Description,
                        Status = task.Status

                    });
                }
            }
            ViewTaskModel model = new ViewTaskModel()
            {
                MyTasks = viewTasks
            };

            return View(model);
        }

        [Route("CurrentTasks")]
        public IActionResult CurrentTasks()
        {

            List<TasksViewModel> viewTasks = new List<TasksViewModel>();


            foreach (var task in _allTasks)
            {
                if (task.Status == Status.InProgress)
                {
                    viewTasks.Add(new TasksViewModel()
                    {
                        Id = task.Id,
                        FirstName = task.User.Firstname,
                        LastName = task.User.Lastname,
                        Title = task.Title,
                        Description = task.Description,
                        Status = task.Status

                    });

                }

            }
            ViewTaskModel model = new ViewTaskModel()
            {
                MyTasks = viewTasks
            };

            return View(model);
        }

    

        [HttpGet("Task")]
        public IActionResult Task()
        {

            NewTaskModel model = new NewTaskModel();


            return View(model);
        }

        [HttpPost("Task")]
        public IActionResult Task(NewTaskModel model)
        {


            CacheDb.UserId++;
            User anotherUser = new User()
            {
                Id = CacheDb.UserId,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Age = model.Age,
                AverageFreeTime = model.AverageFreeTime,
                MyTasks = model.MyTasks

            };
            CacheDb._Task_Id++;
            _Task_ anotherTask = new _Task_()
            {
                Id = CacheDb._Task_Id,
                User = anotherUser,
                Title = model.Title,
                Description = model.Description,
                Status = model.Status
            };


            Users.Add(anotherUser);
            _allTasks.Add(anotherTask);
            return View("_ConfirmAddedTask");

        }


        //[Route("EditTask")]
        //[HttpGet("EditTask")]
        //public IActionResult EditTask(int? id)
        //{
        //    List<TasksViewModel> viewTasks = new List<TasksViewModel>();
        //    foreach (var task in _allTasks)
        //    {
        //        viewTasks.Add(new TasksViewModel

        //        {
        //            Id = task.Id,              
        //            Title = task.Title,
        //            Description = task.Description,
        //            Status = task.Status


        //        });

        //    }

        //    ViewTaskModel editModel = new ViewTaskModel()
        //    {
        //        MyTasks = viewTasks
        //    };

        //    var TaskToRemove = editModel.MyTasks.SingleOrDefault(x => x.Id == id) ;

        //    if (TaskToRemove == null) return NotFound($"Task with id: {id} was not found");

        //    return View(TaskToRemove);
        //}

        //[HttpPost("EditTask")]
        //public IActionResult EditTask(_Task_ task)
        //{

        //    var edit_Task = _allTasks.SingleOrDefault(x => x.Id == task.Id);
        //        if (edit_Task == null) return NotFound($"Task was not found");


        //    edit_Task.Title = task.Title;
        //    edit_Task.Description = task.Description;
        //    edit_Task.Status = task.Status;
        //    edit_Task.PriorityLevel = task.PriorityLevel;


        //    return RedirectToAction("Statistics");

        //}
        
        [HttpGet("EditTask")]
        public IActionResult EditTask()
        {
           _Task_ task = new _Task_();


            return View(task);

            
        }

        [HttpPost("EditTask")]
        public IActionResult EditTask(_Task_ editedtask)
        {
            List<TasksViewModel> viewTasks = new List<TasksViewModel>();


            foreach (var task in _allTasks)
            {
              
                viewTasks.Add(new TasksViewModel()
                    {
                        Id = task.Id,
                        FirstName = task.User.Firstname,
                        LastName = task.User.Lastname,
                        Title = task.Title,
                        Description = task.Description,
                        Status = task.Status

                    });

                if (task.Id == editedtask.Id)
                {
                    task.Title = editedtask.Title;
                    task.Description = editedtask.Description;
                    task.Status = editedtask.Status;
                }
                else return NotFound($"Task was not found");

            }
            ViewTaskModel model = new ViewTaskModel()
            {
                MyTasks = viewTasks
            };

          
            //var edit_Task = model.MyTasks.SingleOrDefault(x => x.Id == editedtask.Id);
            //if (edit_Task == null) return NotFound($"Task was not found");


            //edit_Task.Title = task.Title;
            //edit_Task.Description = task.Description;
            //edit_Task.Status = task.Status;



            return RedirectToAction("Statistics");

        }





    }
}
