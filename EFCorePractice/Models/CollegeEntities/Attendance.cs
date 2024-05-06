using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Attendance
{
    [Key]
    public int AttendanceId { get; set; }

    public DateOnly AttendanceDate { get; set; }

    public bool IsPresent { get; set; }

    public int? StudentId { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; }

    public virtual Student Student { get; set; }
}
