using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Assignment
{
    [Key]
    public int AssignmentId { get; set; }

    public string AssignmentName { get; set; }

    public DateOnly? DueDate { get; set; }

    public int? CourseId { get; set; }


    public virtual Course Course { get; set; }
}
