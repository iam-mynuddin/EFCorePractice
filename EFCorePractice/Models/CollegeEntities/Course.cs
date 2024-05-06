using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Course
{
    [Key]
    public int CourseId { get; set; }

    public string CourseName { get; set; }
}
