﻿using System;
using System.Collections.Generic;

namespace PaginaToros.Shared.Models;

public partial class Establecimiento
{
    public int Id { get; set; }

    public int Codigo { get; set; }
    public string? NombreSocio { get; set; }

    public bool? Activo { get; set; }

    public string? Nombre { get; set; }

    public string? Encargado { get; set; }

    public string? Domicilio { get; set; }

    public string? Telefono { get; set; }

    public string? Localidad { get; set; }

    public string? CodPostal { get; set; }

    public string? Provincia { get; set; }

    public string? Informacion { get; set; }

    public int? CodZona { get; set; }

    public DateTime? FechaExistencia { get; set; }
}
