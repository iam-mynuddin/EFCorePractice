﻿using System;
using System.Collections.Generic;

namespace EFCorePractice.Models.CollegeEntities;

public partial class Faculty
{
    public int FacultyId { get; set; }

    public string MailId { get; set; }

    public string MobileNumber { get; set; }

    public string FacultyDepartment { get; set; }

    public int? UserId { get; set; }

    public string Address { get; set; }

    public string FullName { get; set; }
    public virtual User User { get; set; }
}
