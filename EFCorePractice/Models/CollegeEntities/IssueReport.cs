using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class IssueReport
{
    public long TicketId { get; set; }

    public string Description { get; set; }

    public bool IsResolved { get; set; }

    public int? UserId { get; set; }

    public virtual User User { get; set; }
}
