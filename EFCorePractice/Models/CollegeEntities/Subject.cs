using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Subject
{
    [Key]
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }

    public int? CourseId { get; set; }

    public virtual Course Course { get; set; }

}
