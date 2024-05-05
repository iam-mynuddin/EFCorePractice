using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class FeeDetail
{
    public int FeeId { get; set; }

    public double Amount { get; set; }

    public string FeeName { get; set; }

    public DateOnly DueDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public bool HasPaid { get; set; }

    public int? StudentId { get; set; }

    public virtual Student Student { get; set; }
}
