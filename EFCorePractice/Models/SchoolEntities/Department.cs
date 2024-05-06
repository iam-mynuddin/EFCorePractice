using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

}
