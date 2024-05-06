using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Calendar
{
    [Key]
    public int CalendarId { get; set; }

    public string Message { get; set; }

    public string Status { get; set; }

    public string Reason { get; set; }

    public DateTime? TargetDate { get; set; }
}
