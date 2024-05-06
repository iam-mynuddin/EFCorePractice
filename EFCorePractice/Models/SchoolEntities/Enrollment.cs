using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Enrollment
{
    [Key]
    public int EnrollmentId { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public int? GradeId { get; set; }

    public virtual Course Course { get; set; }

    public virtual Grade Grade { get; set; }

    public virtual Student Student { get; set; }
}
