namespace MostreOCodigo.Domain.Repositories.Services
{
    public interface IValorServices
    {
        Task<Tuple<decimal, decimal>> CalcularValores(string origem, string destino, int tempo, int plano);
    }
}
