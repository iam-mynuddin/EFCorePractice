using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class FacultySubject
{
    [Key]
    public int Id { get; set; }

    public int? SubjectId { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; }

    public virtual Subject Subject { get; set; }
}
