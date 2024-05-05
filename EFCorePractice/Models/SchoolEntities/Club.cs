using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Club
{
    public int ClubId { get; set; }

    public string ClubName { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
