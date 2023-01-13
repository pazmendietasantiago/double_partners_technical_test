using System.Runtime.Serialization;

namespace DoublePartnersAPI.DTO
{
    [DataContract]
    public class PersonDTO
    {
        [DataMember]
        public int Id { get; set; } = 0;

        [DataMember]
        public string Nombres { get; set; } = string.Empty;

        [DataMember]
        public string Apellidos { get; set; } = string.Empty;

        [DataMember] 
        public string NombreCompleto { get; set; } = string.Empty;

        [DataMember]
        public string TipoIdentificacion { get; set; } = string.Empty;

        [DataMember]
        public string Identificacion { get; set; } = string.Empty;

        [DataMember]
        public string Email { get; set; } = string.Empty;

        [DataMember]
        public string IdentificacionCompleta { get; set; } = string.Empty;

        [DataMember]
        public DateTime? FechaCreacion { get; set; } = null;
    }
}
