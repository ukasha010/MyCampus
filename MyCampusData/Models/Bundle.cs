﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MyCampusData.Models;

public partial class Bundle
{
    public Guid Id { get; set; }

    public long BundleSize { get; set; }

    public int BundleFiles { get; set; }

    public DateTime ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<ClassAssignmentSubmission> ClassAssignmentSubmissions { get; set; } = new List<ClassAssignmentSubmission>();

    public virtual ICollection<ClassAssignment> ClassAssignments { get; set; } = new List<ClassAssignment>();
}