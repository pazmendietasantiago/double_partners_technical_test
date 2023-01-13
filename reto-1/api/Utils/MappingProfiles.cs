using AutoMapper;
using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Models;

namespace DoublePartnersAPI.Utils
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PersonDTO, Persona>();
            CreateMap<Persona, PersonDTO>();

            CreateMap<UserDTO, Usuario>();
            CreateMap<Usuario, UserDTO>();
        }
    }
}
