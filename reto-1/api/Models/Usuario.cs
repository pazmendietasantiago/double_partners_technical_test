namespace DoublePartnersAPI.Models;

/// <summary>
/// Guarda la información relacionada a los usuarios que se pueden registrar y autenticar en el sistema
/// </summary>
public partial class Usuario
{
    /// <summary>
    /// Identificador único del usuario en el sistema
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identificador que utilizará el usuario para realizar actividades de autenticación
    /// </summary>
    public string Usuario1 { get; set; } = null!;

    /// <summary>
    /// Clave de usuario cifrada
    /// </summary>
    public string Clave { get; set; } = null!;

    /// <summary>
    /// Fecha de la creaicón del usuario en el sistema
    /// </summary>
    public DateTime? FechaCreacion { get; set; }
}
