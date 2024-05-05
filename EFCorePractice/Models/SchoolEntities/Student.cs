using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.SchoolEntities;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public virtual ICollection<AssignmentResult> AssignmentResults { get; set; } = new List<AssignmentResult>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<ExamResult> ExamResults { get; set; } = new List<ExamResult>();

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();
}
