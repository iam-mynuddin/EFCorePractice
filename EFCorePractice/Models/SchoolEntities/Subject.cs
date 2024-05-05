using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
