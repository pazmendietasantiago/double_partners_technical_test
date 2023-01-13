using DoublePartnersAPI.DTO;

namespace DoublePartnersAPI.Repository.Interfaces
{
    public interface IPersonRepository
    {
        public Task<bool> SavePerson(PersonDTO person);
        public Task<IEnumerable<PersonDTO>> GetPersons(int page, int registersPerPage);
    }
}
