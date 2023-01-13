using System.Runtime.Serialization;

namespace DoublePartnersAPI.DTO
{
    [DataContract]
    public class AuthUserDTO
    {
        [DataMember]
        public string UserName { get; set; } = string.Empty;

        [DataMember]
        public string Password { get; set; } = string.Empty;
    }
}
