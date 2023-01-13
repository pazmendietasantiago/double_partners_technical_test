using System;
using System.Collections.Generic;

namespace DoublePartnersAPI.Models;

/// <summary>
/// Almacena la información relacionada a las personas vinculadas a la plataforma
/// </summary>
public partial class Persona
{
    /// <summary>
    /// Identificador único de la persona en la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombres completos de la persona
    /// </summary>
    public string Nombres { get; set; } = null!;

    /// <summary>
    /// Apellidos completos de la persona
    /// </summary>
    public string Apellidos { get; set; } = null!;

    /// <summary>
    /// Número de identificación del DNI de la persona
    /// </summary>
    public string Identificacion { get; set; } = null!;

    /// <summary>
    /// Dirección de correo electronico de la persona
    /// </summary>
    public string? Email { get; set; }

    public string TipoIdentificacion { get; set; } = null!;

    public string IdentificacionCompleta { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }
}
