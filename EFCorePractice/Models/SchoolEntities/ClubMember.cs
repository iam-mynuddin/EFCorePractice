using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models.SchoolEntities
{
    [Keyless]
    public partial class ClubMember
    {
        public int ClubId { get; set; }

        public string StudentId { get; set; }

    }
}
