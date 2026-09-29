using UserDetails.Domain.DTOs;

namespace UserDetails.Application.Interfaces
{
    public interface IUserDetails
    {
        public Task<List<UserDetailsDTO>> GetUserDetails();
    }
}
