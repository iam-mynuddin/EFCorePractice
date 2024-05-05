using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Parent
{
    public int ParentId { get; set; }

    public string Address { get; set; }

    public string MobileNumber { get; set; }

    public int UserId { get; set; }

    public string MailId { get; set; }

    public string FullName { get; set; }

    public virtual User User { get; set; }
}
