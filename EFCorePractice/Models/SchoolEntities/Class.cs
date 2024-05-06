using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Class
{
    [Key]
    public int ClassId { get; set; }

    public string ClassName { get; set; }

    public int? TeacherId { get; set; }

    public virtual Teacher Teacher { get; set; }
}
