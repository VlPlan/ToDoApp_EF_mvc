using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;


namespace ToDo.App.DataAccess
{
    public static class CacheDb
    {
        public static List<SubTask> SubTasks;
        public static List<_Task_> _Tasks;
        public static List<User> Users;
        public static int UserId;
        public static int _Task_Id;
        public static int SubTaskId;

        static CacheDb()
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

            _Tasks = new List<_Task_>()
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


            UserId = 3;
            _Task_Id = 4;
            SubTaskId = 5;


        }
    }
}

