using MostreOCodigo.Domain.Models;

namespace MostreOCodigo.Domain.Repositories.Interfaces
{
    public interface IValorRepository
    {
        Task<Valor> Obter(string origem, string destino);
    }
}
