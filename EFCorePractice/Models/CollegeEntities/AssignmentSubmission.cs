using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class AssignmentSubmission
{
    public int SubmissionId { get; set; }

    public string Answer { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public int? SubjectId { get; set; }

    public int? AssignmentId { get; set; }

    public string Feedback { get; set; }

    public bool? Reviewed { get; set; }

    public string Status { get; set; }

    public virtual Assignment Assignment { get; set; }

    public virtual Course Course { get; set; }

    public virtual Student Student { get; set; }

    public virtual Subject Subject { get; set; }
}
