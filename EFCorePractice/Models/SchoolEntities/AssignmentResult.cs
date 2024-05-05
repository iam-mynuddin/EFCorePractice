using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class AssignmentResult
{
    public int ResultId { get; set; }

    public int? StudentId { get; set; }

    public int? AssignmentId { get; set; }

    public int? GradeId { get; set; }

    public virtual Assignment Assignment { get; set; }

    public virtual Grade Grade { get; set; }

    public virtual Student Student { get; set; }
}
