using DoublePartnersAPI.DTO;

namespace DoublePartnersAPI.Repository.Interfaces
{
    public interface IUserRepository
    {
        public Task<bool> SaveUser(UserDTO user);

        public Task<IEnumerable<UserDTO>> GetUsers();
    }
}
