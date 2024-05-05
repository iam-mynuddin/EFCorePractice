using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Grade
{
    public int GradeId { get; set; }

    public string GradeName { get; set; }

    public virtual ICollection<AssignmentResult> AssignmentResults { get; set; } = new List<AssignmentResult>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<ExamResult> ExamResults { get; set; } = new List<ExamResult>();
}
