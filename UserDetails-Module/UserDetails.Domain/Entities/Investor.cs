using System;
using System.Collections.Generic;

namespace UserDetails.Domain.Entities
{
    public partial class Investor
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

        public string Password { get; set; } = null!;

        public bool? IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? DeactivationBy { get; set; }

        public DateTime? DeactivationDate { get; set; }
    }
}