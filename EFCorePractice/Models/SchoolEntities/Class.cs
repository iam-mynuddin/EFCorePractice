using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; }

    public int? TeacherId { get; set; }

    public virtual Teacher Teacher { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
