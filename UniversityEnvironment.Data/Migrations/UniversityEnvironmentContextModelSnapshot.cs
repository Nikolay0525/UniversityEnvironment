﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityEnvironment.Data;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    [DbContext(typeof(UniversityEnvironmentContext))]
    partial class UniversityEnvironmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.CourseStudent", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("coursesstudents", (string)null);
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.CourseTeacher", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("coursesteachers", (string)null);
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.QuestionAnswerStudent", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("QuestionAnswerId")
                        .HasColumnType("char(36)");

                    b.HasKey("StudentId", "QuestionAnswerId");

                    b.HasIndex("QuestionAnswerId");

                    b.ToTable("questionanswersstudents", (string)null);
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.TestStudent", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TestId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "TestId");

                    b.HasIndex("TestId");

                    b.ToTable("testsstudents", (string)null);
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("CanChangePassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<bool>("ForgetPassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<bool>("SuperAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FacultyName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.QuestionAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AnswerText")
                        .HasColumnType("longtext");

                    b.Property<Guid>("TestQuestionId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TestQuestionId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("CanChangePassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<bool>("ForgetPassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.StudentMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CourseName")
                        .HasColumnType("longtext");

                    b.Property<string>("Initials")
                        .HasColumnType("longtext");

                    b.Property<string>("MessageText")
                        .HasColumnType("longtext");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentMessages");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("CanChangePassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<bool>("ForgetPassword")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("ScienceDegree")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.TestQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("ManyAnswers")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("QuestionText")
                        .HasColumnType("longtext");

                    b.Property<Guid>("TestId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("TestQuestions");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.CourseStudent", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Course", "Course")
                        .WithMany("CoursesStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Student", "Student")
                        .WithMany("CoursesStudents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.CourseTeacher", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Course", "Course")
                        .WithMany("CoursesTeachers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Teacher", "Teacher")
                        .WithMany("CoursesTeachers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.QuestionAnswerStudent", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.QuestionAnswer", "QuestionAnswer")
                        .WithMany("QuestionAnswersStudents")
                        .HasForeignKey("QuestionAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Student", "Student")
                        .WithMany("QuestionAnswersStudent")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionAnswer");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.MtoMTables.TestStudent", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Student", "Student")
                        .WithMany("TestsStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Test", "Test")
                        .WithMany("TestsStudents")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.QuestionAnswer", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.TestQuestion", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("TestQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.StudentMessage", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Student", "Student")
                        .WithMany("StudentMessages")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Test", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Course", "Course")
                        .WithMany("Tests")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.TestQuestion", b =>
                {
                    b.HasOne("UniversityEnvironment.Data.Model.Tables.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Course", b =>
                {
                    b.Navigation("CoursesStudents");

                    b.Navigation("CoursesTeachers");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.QuestionAnswer", b =>
                {
                    b.Navigation("QuestionAnswersStudents");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Student", b =>
                {
                    b.Navigation("CoursesStudents");

                    b.Navigation("QuestionAnswersStudent");

                    b.Navigation("StudentMessages");

                    b.Navigation("TestsStudents");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Teacher", b =>
                {
                    b.Navigation("CoursesTeachers");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("TestsStudents");
                });

            modelBuilder.Entity("UniversityEnvironment.Data.Model.Tables.TestQuestion", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
