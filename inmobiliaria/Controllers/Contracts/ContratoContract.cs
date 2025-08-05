namespace Inmobiliaria.Controllers.Contracts
{
    public class ContratoContract
    {
        public long? IdContrato { get; set; }
        public long? IdTenant { get; set; }
        public long? IdInquilino { get; set; }
        public long? IdPropiedad { get; set; }
        public long? IdUnidad { get; set; }

        public string? NumeroContrato { get; set; }

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

        public decimal MontoMensual { get; set; }
        public decimal? MontoDeposito { get; set; }

        public decimal? AjustePorcentaje { get; set; }
        public int? PeriodoAjuste { get; set; }
        public DateOnly? FechaUltimoAjuste { get; set; }

        public string Estado { get; set; } = "activo";

        public string? Observaciones { get; set; }
        public string? ClausulasEspeciales { get; set; }

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public bool Eliminado { get; set; } = false;
        public DateTime? FechaEliminacion { get; set; }
    }
}
