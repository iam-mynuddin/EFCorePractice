using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual Course Course { get; set; }

    public virtual ICollection<FacultySubject> FacultySubjects { get; set; } = new List<FacultySubject>();
}
