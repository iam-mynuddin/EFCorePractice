using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
