using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class FacultySubject
{
    public int Id { get; set; }

    public int? SubjectId { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; }

    public virtual Subject Subject { get; set; }
}
