﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCampusData.Data;

#nullable disable

namespace MyCampusData.Migrations
{
    [DbContext(typeof(CampusContext))]
    [Migration("20220930192456_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyCampusData.Entities.BundleFileEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BundleFiles")
                        .HasColumnType("int");

                    b.Property<long>("BundleSize")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Bundles");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassAssignmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentBundleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignmentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndSubmissionAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentBundleId");

                    b.HasIndex("ClassId");

                    b.ToTable("ClassAssignments");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassAssignmentSubmissionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentSubmissionBundleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LecturerEvaluation")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LecturerNotes")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubmissionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("AssignmentSubmissionBundleId");

                    b.HasIndex("StudentId");

                    b.ToTable("ClassAssignmentSubmissions");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClassFinishAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClassStartAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LecturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassMeetingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LecturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MeetingUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("LecturerId");

                    b.ToTable("ClassMeetings");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizAnswerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRight")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("ClassQuizAnswers");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("ClassQuizzes");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizQuestionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("ClassQuizQuestions");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizSubmissionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("StudentId");

                    b.ToTable("ClassQuizSubmissions");
                });

            modelBuilder.Entity("MyCampusData.Entities.CourseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MyCampusData.Entities.SessionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("MyCampusData.Entities.UserClassEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Evaluation")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("UserClasses");
                });

            modelBuilder.Entity("MyCampusData.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Permissions")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassAssignmentEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.BundleFileEntity", "AssignmentBundle")
                        .WithMany()
                        .HasForeignKey("AssignmentBundleId");

                    b.HasOne("MyCampusData.Entities.ClassEntity", "Class")
                        .WithMany("Assignments")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignmentBundle");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassAssignmentSubmissionEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassAssignmentEntity", "Assignment")
                        .WithMany("AssignmentSubmissions")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCampusData.Entities.BundleFileEntity", "AssignmentSubmissionBundle")
                        .WithMany()
                        .HasForeignKey("AssignmentSubmissionBundleId");

                    b.HasOne("MyCampusData.Entities.UserEntity", "Student")
                        .WithMany("AssignmentSubmissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("AssignmentSubmissionBundle");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.CourseEntity", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCampusData.Entities.UserEntity", "Lecturer")
                        .WithMany("LecturingClasses")
                        .HasForeignKey("LecturerId");

                    b.Navigation("Course");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassMeetingEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassEntity", "Class")
                        .WithMany("Meetings")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCampusData.Entities.UserEntity", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizAnswerEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassQuizQuestionEntity", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassEntity", "Class")
                        .WithMany("Quizzes")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizQuestionEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassQuizEntity", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizSubmissionEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassQuizEntity", "Quiz")
                        .WithMany("Submissions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCampusData.Entities.UserEntity", "Student")
                        .WithMany("ExamSubmissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MyCampusData.Entities.SessionEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.UserEntity", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyCampusData.Entities.UserClassEntity", b =>
                {
                    b.HasOne("MyCampusData.Entities.ClassEntity", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCampusData.Entities.UserEntity", "Student")
                        .WithMany("Classes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassAssignmentEntity", b =>
                {
                    b.Navigation("AssignmentSubmissions");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassEntity", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Meetings");

                    b.Navigation("Quizzes");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizEntity", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("MyCampusData.Entities.ClassQuizQuestionEntity", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("MyCampusData.Entities.CourseEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("MyCampusData.Entities.UserEntity", b =>
                {
                    b.Navigation("AssignmentSubmissions");

                    b.Navigation("Classes");

                    b.Navigation("ExamSubmissions");

                    b.Navigation("LecturingClasses");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
