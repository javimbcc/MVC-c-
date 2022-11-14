using System;
using System.Collections.Generic;

namespace RUTASEJEMPLO_DAL.Modelos;

/// <summary>
/// Entidad que regula los alumnos
/// </summary>
public partial class Alumno
{
    public long Id { get; set; }

    public string AlumnoNombre { get; set; } = null!;

    public string AlumnoApellido1 { get; set; } = null!;

    public string AlumnoApellido2 { get; set; } = null!;

    public long AlumnoEdad { get; set; }

    public string AlumnoCorreo { get; set; } = null!;

    public string AlumnoFechaNacimiento { get; set; } = null!;
}
