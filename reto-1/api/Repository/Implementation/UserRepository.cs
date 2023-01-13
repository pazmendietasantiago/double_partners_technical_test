using AutoMapper;
using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Models;
using DoublePartnersAPI.Repository.Interfaces;
using DoublePartnersAPI.Utils;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DoublePartnersAPI.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DoublePartnersContext context;
        private readonly IMapper mapper;

        public UserRepository(DoublePartnersContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            try
            {
                IEnumerable<Usuario> usuarios = await context.Usuarios.ToListAsync();

                IEnumerable<UserDTO> users = mapper.Map<List<UserDTO>>(usuarios);

                return users;
            }
            catch (Exception)
            {

                return Enumerable.Empty<UserDTO>();
            }
        }

        public async Task<bool> SaveUser(UserDTO user)
        {
            try
            {
                Usuario usuario = mapper.Map<Usuario>(user);

                usuario.Usuario1 = user.Usuario1;
                usuario.Clave = Common.ProcessStringAsMD5(usuario.Clave);

                await context.Usuarios.AddAsync(usuario);

                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
