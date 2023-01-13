using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Models;
using DoublePartnersAPI.Repository.Interfaces;
using DoublePartnersAPI.Utils;
using Microsoft.EntityFrameworkCore;

namespace DoublePartnersAPI.Repository.Implementation
{
    public class SecurityRepository : ISecurityRepository
    {
        private readonly DoublePartnersContext context;

        public SecurityRepository(DoublePartnersContext context)
        {
            this.context = context;
        }

        public async Task<bool> Login(AuthUserDTO authUser)
        {
            string decodedUser = Common.Base64Decode(authUser.UserName);
            string decodedKey = Common.Base64Decode(authUser.Password);

            string stringProccessed = Common.ProcessStringAsMD5(decodedKey);

            bool userExists = await context.Usuarios.AnyAsync(user => user.Usuario1 == decodedUser && user.Clave == stringProccessed);

            return userExists;
        }
    }
}
