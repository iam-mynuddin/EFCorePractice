using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentDepartment { get; set; }

    public string StudentYear { get; set; }

    public string MailId { get; set; }

    public string MobileNumber { get; set; }

    public string Address { get; set; }

    public int? UserId { get; set; }

    public string FullName { get; set; }

    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<FeeDetail> FeeDetails { get; set; } = new List<FeeDetail>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual User User { get; set; }
}
