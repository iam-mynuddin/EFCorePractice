using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class LeaveDetail
{
    public int Id { get; set; }

    public string Reason { get; set; }

    public DateOnly DateOfLeave { get; set; }

    public bool IsApproved { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; }
}
