﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.App.DataAccess;

namespace ToDo.App.DataAccess.Migrations
{
    [DbContext(typeof(ToDoAppDbContext))]
    partial class ToDoAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDo.App.Domain._Task_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("PriorityLevel");

                    b.Property<int>("Status");

                    b.Property<int?>("SubtaskId");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SubtaskId");

                    b.HasIndex("UserId");

                    b.ToTable("_Tasks");

                    b.HasData(
                        new { Id = 1, Description = "After Work tasks", PriorityLevel = 1, Status = 2, Title = "My wednesday activities", Type = 1, UserId = 1 },
                        new { Id = 2, Description = "check recieved emails from our buyers", PriorityLevel = 0, Status = 2, Title = "Check Emails", Type = 0, UserId = 2 },
                        new { Id = 3, Description = "Gym training on Saturday", PriorityLevel = 2, Status = 2, Title = "Training", Type = 2, UserId = 3 },
                        new { Id = 4, Description = "Meeting with clients at 9am", PriorityLevel = 0, Status = 2, Title = "Work activities", Type = 0, UserId = 2 }
                    );
                });

            modelBuilder.Entity("ToDo.App.Domain.Models.SubtaskFromTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubTaskId");

                    b.Property<int>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("SubTaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("SubtaskFromTask");

                    b.HasData(
                        new { Id = 1, SubTaskId = 1, TaskId = 1 },
                        new { Id = 2, SubTaskId = 2, TaskId = 1 },
                        new { Id = 3, SubTaskId = 3, TaskId = 2 },
                        new { Id = 4, SubTaskId = 4, TaskId = 3 },
                        new { Id = 5, SubTaskId = 5, TaskId = 4 }
                    );
                });

            modelBuilder.Entity("ToDo.App.Domain.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.Property<int?>("_Task_Id");

                    b.HasKey("Id");

                    b.HasIndex("_Task_Id");

                    b.ToTable("SubTasks");

                    b.HasData(
                        new { Id = 1, Description = "shopping", Status = 2, Title = "Go to supermarket", _Task_Id = 1 },
                        new { Id = 2, Description = "sport", Status = 2, Title = "Gym", _Task_Id = 1 },
                        new { Id = 3, Description = "check colleague's mail while he is on holiday", Status = 2, Title = "Check my colleague email", _Task_Id = 2 },
                        new { Id = 4, Description = "pay membership for Gym", Status = 2, Title = "Gym membership", _Task_Id = 3 },
                        new { Id = 5, Description = "Sign new agreement for cooperation for 2019", Status = 2, Title = "Agreement", _Task_Id = 4 }
                    );
                });

            modelBuilder.Entity("ToDo.App.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<double>("AverageFreeTime");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Age = 33, AverageFreeTime = 4.0, Firstname = "Slave", Lastname = "Konev" },
                        new { Id = 2, Age = 26, AverageFreeTime = 2.0, Firstname = "Marina", Lastname = "Mihajlova" },
                        new { Id = 3, Age = 30, AverageFreeTime = 1.0, Firstname = "Igor", Lastname = "Terzic" }
                    );
                });

            modelBuilder.Entity("ToDo.App.Domain._Task_", b =>
                {
                    b.HasOne("ToDo.App.Domain.SubTask", "Subtask")
                        .WithMany()
                        .HasForeignKey("SubtaskId");

                    b.HasOne("ToDo.App.Domain.User", "User")
                        .WithMany("MyTasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDo.App.Domain.Models.SubtaskFromTask", b =>
                {
                    b.HasOne("ToDo.App.Domain.SubTask", "SubTask")
                        .WithMany("SubtasksFromTask")
                        .HasForeignKey("SubTaskId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToDo.App.Domain._Task_", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDo.App.Domain.SubTask", b =>
                {
                    b.HasOne("ToDo.App.Domain._Task_", "Task")
                        .WithMany("SubTasks")
                        .HasForeignKey("_Task_Id");
                });
#pragma warning restore 612, 618
        }
    }
}