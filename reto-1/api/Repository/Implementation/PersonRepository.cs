using AutoMapper;
using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Models;
using DoublePartnersAPI.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DoublePartnersAPI.Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DoublePartnersContext context;
        private readonly IMapper mapper;

        public PersonRepository(DoublePartnersContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<PersonDTO>> GetPersons(int page, int registersPerPage)
        {
            const string query = "EXEC [DBO].getPersons @page, @registersPerPage";

            SqlParameter[] parameters =
            {
                new SqlParameter("@page", page),
                new SqlParameter("@registersPerPage", registersPerPage)
            };

            try
            {
                IEnumerable<Persona> databasePersons = await context.Personas.FromSqlRaw(query, parameters).ToListAsync();

                IEnumerable<PersonDTO> persons = mapper.Map<List<PersonDTO>>(databasePersons);

                return persons;
            }
            catch (Exception)
            {

                return Enumerable.Empty<PersonDTO>();
            }
        }

        public async Task<bool> SavePerson(PersonDTO person)
        {
            try
            {
                Persona persona = mapper.Map<Persona>(person);

                await context.Personas.AddAsync(persona);

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
