using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities
{
    [Keyless]
    public partial class ClassSubject
    {
        public int ClassId { get; set; }

        public string SubjectId { get; set; }

    }
}
