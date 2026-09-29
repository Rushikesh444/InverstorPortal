using InvestorDbContext;
using Microsoft.EntityFrameworkCore;
using UserDetails.Domain.DTOs;
using UserDetails.Application.Interfaces;

namespace UserDetails.Infrastructure.Services
{
    public class UserDetailsService : IUserDetails
    {
        private readonly AppDbContext _dbContext;
        public UserDetailsService(AppDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<List<UserDetailsDTO>> GetUserDetails()
        {
            var result = await _dbContext.Investors.Select(x => new UserDetailsDTO
            {
                InvestorId = x.InvestorId,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                Gender= x.Gender,
                Email = x.Email,
                CountryName = x.CountryName,    
                Mobile = x.Mobile,
                IdentityProofType = x.IdentityProofType,
                IdentityProofNumber = x.IdentityProofNumber,
                DateOfBirth = x.DateOfBirth,
                IsActive = x.IsActive
            }).ToListAsync();

            return result;
        }
    }
}
