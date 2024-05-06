using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

}
