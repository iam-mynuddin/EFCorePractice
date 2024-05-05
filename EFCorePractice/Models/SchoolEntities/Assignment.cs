using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public string AssignmentName { get; set; }

    public DateOnly? DueDate { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<AssignmentResult> AssignmentResults { get; set; } = new List<AssignmentResult>();

    public virtual Course Course { get; set; }
}
