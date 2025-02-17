﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MyCampusData.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string Username { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public int Gender { get; set; }

    public int Permissions { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<ClassAssignmentSubmission> ClassAssignmentSubmissions { get; set; } = new List<ClassAssignmentSubmission>();

    public virtual ICollection<ClassMeeting> ClassMeetings { get; set; } = new List<ClassMeeting>();

    public virtual ICollection<ClassQuizSubmission> ClassQuizSubmissions { get; set; } = new List<ClassQuizSubmission>();

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();

    public virtual ICollection<UserClass> UserClasses { get; set; } = new List<UserClass>();
}