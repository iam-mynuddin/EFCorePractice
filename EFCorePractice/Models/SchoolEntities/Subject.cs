using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Subject
{
    [Key]
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }

}
