using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserType { get; set; }
}
