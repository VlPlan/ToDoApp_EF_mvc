using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ToDo.App.Domain;
using ToDo.App.Domain.Models;
using Microsoft.SqlServer.Server;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace ToDo.App.DataAccess
{
    public class ToDoAppDbContext : DbContext
    {


        public ToDoAppDbContext()
        {
        }



        

            public ToDoAppDbContext(DbContextOptions options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder model)
        {
            model.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoAppDbContext;Trusted_Connection=True");
            base.OnConfiguring(model);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<_Task_> _Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }



        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
      


        model.Entity<_Task_>().HasMany<SubTask>(x => x.SubTasks).WithOne(x => x.Task).HasForeignKey(x => x._Task_Id);
            model.Entity<SubTask>().HasMany<SubtaskFromTask>(x => x.SubtasksFromTask).WithOne(x => x.SubTask).HasForeignKey(x => x.SubTaskId);
            model.Entity<User>().HasMany(x => x.MyTasks).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            model.Entity<User>().HasData(new User[]
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

        });



            model.Entity<SubTask>().HasData(new SubTask[]
            {
            new SubTask()
                     {
                         Id = 1,
                         Title = "Go to supermarket",
                         Description = "shopping",
                         Status = Status.NotDone,
                         _Task_Id = 1
                     },

                    new SubTask()
                    {
                        Id = 2,
                        Title = "Gym",
                        Description = "sport",
                        Status = Status.NotDone,
                        _Task_Id = 1
                    },
                    new SubTask()
                    {
                        Id = 3,
                        Title = "Check my colleague email",
                        Description = "check colleague's mail while he is on holiday",
                        Status = Status.NotDone,
                        _Task_Id = 2
                    },

                     new SubTask()
                     {
                         Id = 4,
                         Title = "Gym membership",
                         Description = "pay membership for Gym",
                         Status = Status.NotDone,
                         _Task_Id = 3
                     },

                     new SubTask()
                     {
                         Id = 5,
                         Title = "Agreement",
                         Description = "Sign new agreement for cooperation for 2019",
                         Status = Status.NotDone,
                         _Task_Id = 4
                     }
            });






            model.Entity<_Task_>().HasData(new _Task_[]
            {
                new _Task_
                {
                Id = 1,
                UserId = 1,
                Title = "My wednesday activities",
                Description = "After Work tasks",
                PriorityLevel = PriorityLevel.medium,
                Status = Status.NotDone,
                Type = Domain.Type.Personal
                    },

               new _Task_
               {
                    Id = 2,
                    UserId = 2,
                    Title = "Check Emails",
                    Description = "check recieved emails from our buyers",
                    PriorityLevel = PriorityLevel.important,
                    Status = Status.NotDone,
                    Type = Domain.Type.Work,

                },


           new _Task_
           {
               Id = 3,
               UserId = 3,
               Title = "Training",
               Description = "Gym training on Saturday",
               PriorityLevel = PriorityLevel.notImportant,
               Status = Status.NotDone,
               Type = Domain.Type.Hobby,

           },


           new _Task_
           {
               Id = 4,
               UserId = 2,
               Title = "Work activities",
               Description = "Meeting with clients at 9am",
               PriorityLevel = PriorityLevel.important,
               Status = Status.NotDone,
               Type = Domain.Type.Work,

           }
        });



            model.Entity<SubtaskFromTask>().HasData(new SubtaskFromTask[]
            {
                new SubtaskFromTask
                {
                    Id = 1,
                    TaskId = 1,
                    SubTaskId = 1

                },
                              new SubtaskFromTask
                              {
                                 Id = 2,
                                 TaskId = 1,
                                 SubTaskId = 2

                             },

                                          new SubtaskFromTask
                                          {
                                              Id = 3,
                                              TaskId = 2,
                                              SubTaskId = 3

                                          },

                                                        new SubtaskFromTask
                                                        {
                                                           Id = 4,
                                                           TaskId = 3,
                                                           SubTaskId = 4

                                                       },
                                                        new SubtaskFromTask
                                                        {
                                                           Id = 5,
                                                           TaskId = 4,
                                                           SubTaskId = 5
                                                       }
        });



        }

        public void SaveChanges(_Task_ taskToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
