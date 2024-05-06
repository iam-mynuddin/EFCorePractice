using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    public string StudentDepartment { get; set; }

    public string StudentYear { get; set; }

    public string MailId { get; set; }

    public string MobileNumber { get; set; }

    public string Address { get; set; }

    public int? UserId { get; set; }

    public string FullName { get; set; }
    public virtual User User { get; set; }
}
