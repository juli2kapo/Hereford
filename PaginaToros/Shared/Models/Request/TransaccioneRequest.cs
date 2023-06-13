﻿namespace PaginaToros.Shared.Models.Request
{
    public class TransaccioneRequest
    {
        public int Id { get; set; }

        public string? NombreVendedor { get; set; } = null!;

        public string? NombreComprador { get; set; } = null!;

        public DateTime? Fecha { get; set; }

        public int? Total { get; set; }

        public string? Toros { get; set; }
    }
}
