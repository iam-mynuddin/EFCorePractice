using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public string Question { get; set; }

    public DateTime? AllotedDate { get; set; }

    public int? CourseId { get; set; }

    public int? StudentId { get; set; }

    public DateOnly? TargetDate { get; set; }

    public int? SubjectId { get; set; }

    public int? FacultyId { get; set; }

    public string Status { get; set; }

    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    public virtual Course Course { get; set; }

    public virtual Faculty Faculty { get; set; }

    public virtual Student Student { get; set; }

    public virtual Subject Subject { get; set; }
}
