using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Grade
{
    [Key]
    public int GradeId { get; set; }

    public string GradeName { get; set; }
}
