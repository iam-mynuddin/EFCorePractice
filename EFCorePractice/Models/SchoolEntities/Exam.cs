using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Exam
{
    [Key]
    public int ExamId { get; set; }

    public string ExamName { get; set; }

    public DateOnly? Date { get; set; }

    public int? CourseId { get; set; }

    public virtual Course Course { get; set; }

}
