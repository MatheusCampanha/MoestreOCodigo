namespace MostreOCodigo.Domain.Models
{
    public class Valor
    {
        public int ValorId { get; set; }
        public string Origem { get; set; } = default!;
        public string Destino { get; set; } = default!;
        public decimal ValorMinuto { get; set; }
    }
}
