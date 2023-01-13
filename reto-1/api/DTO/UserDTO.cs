namespace DoublePartnersAPI.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Usuario1 { get; set; } = null!;

        public string Clave { get; set; } = null!;

        public DateTime? FechaCreacion { get; set; }
    }
}
