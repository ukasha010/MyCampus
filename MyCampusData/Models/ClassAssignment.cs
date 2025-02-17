﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MyCampusData.Models;

public partial class ClassAssignment
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string AssignmentText { get; set; }

    public Guid ClassId { get; set; }

    public DateTime EndSubmissionAt { get; set; }

    public Guid? AssignmentBundleId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Bundle AssignmentBundle { get; set; }

    public virtual Class Class { get; set; }

    public virtual ICollection<ClassAssignmentSubmission> ClassAssignmentSubmissions { get; set; } = new List<ClassAssignmentSubmission>();
}