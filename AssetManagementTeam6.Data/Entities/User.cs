using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssetManagementTeam6.Data.Entities
{
    public class User : BaseEntity<int>
    {
        [Required]
        public string? StaffCode { get; set; }
        [Required]
        public string? Username { get; set; }

        // TODO: type hash password
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public GenderEnum? Gender { get; set; }
        [Required]
        public DateTime? JoinedDate { get; set; }

        // TODO: type TypeEnum
        [Required]
        public string? Type { get; set; }
    }
}
