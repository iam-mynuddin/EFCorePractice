using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities
{
    [Keyless]
    public partial class ClassDepartment
    {
        public int ClassId { get; set; }

        public string DepartmentId { get; set; }

    }
}
