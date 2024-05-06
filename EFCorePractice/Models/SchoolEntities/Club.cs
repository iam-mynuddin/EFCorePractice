using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Club
{
    [Key]
    public int ClubId { get; set; }

    public string ClubName { get; set; }

}
