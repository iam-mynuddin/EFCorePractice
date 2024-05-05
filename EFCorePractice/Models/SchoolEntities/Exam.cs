using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Exam
{
    public int ExamId { get; set; }

    public string ExamName { get; set; }

    public DateOnly? Date { get; set; }

    public int? CourseId { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<ExamResult> ExamResults { get; set; } = new List<ExamResult>();
}
