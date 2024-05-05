using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserType { get; set; }

    public virtual ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();

    public virtual ICollection<IssueReport> IssueReports { get; set; } = new List<IssueReport>();

    public virtual ICollection<LeaveDetail> LeaveDetails { get; set; } = new List<LeaveDetail>();

    public virtual ICollection<Parent> Parents { get; set; } = new List<Parent>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
