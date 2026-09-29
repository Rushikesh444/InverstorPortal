using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails.Domain.DTOs
{
    public class UserDetailsDTO
    {
        public Guid InvestorId { get; set; }

        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string CountryName { get; set; } = null!;

        public string Mobile { get; set; } = null!;

        public string IdentityProofType { get; set; } = null!;

        public string IdentityProofNumber { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public bool? IsActive { get; set; }
    }
}
