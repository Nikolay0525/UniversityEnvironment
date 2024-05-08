﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.Data
{
    public class UniversityEnvironmentContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestMark> TestMarks { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }

        public UniversityEnvironmentContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql("server=localhost;user=root;password=1234;database=UniversalEnvironment", serverVersion);

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasKey(cs => new { cs.UserId, cs.CourseId }); 

            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasOne(cs => cs.Teacher)
            .WithMany(s => s.CoursesTeachers)
            .HasForeignKey(cs => cs.UserId)
            .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CoursesTeachers) 
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasKey(cs => new { cs.UserId, cs.CourseId }); 

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.CoursesStudents) 
            .HasForeignKey(cs => cs.UserId)
            .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CoursesStudents) 
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.Cascade); 


            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasKey(cs => new { cs.StudentId, cs.TestId }); 

            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.TestsStudents) 
            .HasForeignKey(cs => cs.StudentId)
            .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasOne(cs => cs.Test)
            .WithMany(c => c.TestsStudents) 
            .HasForeignKey(cs => cs.TestId)
            .OnDelete(DeleteBehavior.Cascade); 


            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasKey(cs => new { cs.StudentId, cs.QuestionAnswerId }); 

            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.QuestionAnswersStudent) 
            .HasForeignKey(cs => cs.StudentId)
            .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasOne(cs => cs.QuestionAnswer)
            .WithMany(c => c.QuestionAnswersStudents) 
            .HasForeignKey(cs => cs.QuestionAnswerId)
            .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
