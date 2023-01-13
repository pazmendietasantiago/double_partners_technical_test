using DoublePartnersAPI.DTO;

namespace DoublePartnersAPI.Repository.Interfaces
{
    public interface ISecurityRepository
    {
        public Task<bool> Login(AuthUserDTO authUser);
    }
}
