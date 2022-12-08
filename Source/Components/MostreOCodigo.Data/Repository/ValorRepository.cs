using Microsoft.EntityFrameworkCore;
using MostreOCodigo.Data.Context;
using MostreOCodigo.Domain.Models;
using MostreOCodigo.Domain.Repositories.Interfaces;

namespace MostreOCodigo.Data.Repository
{
    public class ValorRepository : IValorRepository
    {
        private readonly SkynetzContext _context;

        public ValorRepository(SkynetzContext context)
        {
            _context = context;
        }

        public async Task<Valor> Obter(string origem, string destino)
        {
            var result = await _context.Valores.FirstOrDefaultAsync(x => x.Origem == origem && x.Destino == destino);

            return result;
        }
    }
}
