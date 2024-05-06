using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Course
{
    [Key]
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public int? TeacherId { get; set; }


    public virtual Teacher Teacher { get; set; }
}
