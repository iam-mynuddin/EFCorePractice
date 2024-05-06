using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Teacher
{
    [Key]
    public int TeacherId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

}
