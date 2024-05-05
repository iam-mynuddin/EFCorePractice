using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class ExamResult
{
    public int ResultId { get; set; }

    public int? StudentId { get; set; }

    public int? ExamId { get; set; }

    public int? GradeId { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual Grade Grade { get; set; }

    public virtual Student Student { get; set; }
}
