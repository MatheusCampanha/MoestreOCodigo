using MostreOCodigo.Domain.Repositories.Interfaces;
using MostreOCodigo.Domain.Repositories.Services;

namespace MostreOCodigo.Domain.Services
{
    public class ValorServices : IValorServices
    {
        private readonly IValorRepository _valorRepository;

        public ValorServices(IValorRepository valorRepository)
        {
            _valorRepository = valorRepository;
        }

        public async Task<Tuple<decimal, decimal>> CalcularValores(string origem, string destino, int tempo, int plano)
        {
            var valorPorLocal = await _valorRepository.Obter(origem, destino);

            if (valorPorLocal == null)
                return null;

            var minutosExtras = tempo - plano;

            if (minutosExtras < 0) 
                minutosExtras = 0;

            var valorMinuto = valorPorLocal.ValorMinuto;
            var tarifa = valorMinuto * (decimal)0.1;


            var valorComPlano = (valorMinuto + tarifa) * minutosExtras;
            var valorSemPlano = valorMinuto * tempo;

            return new Tuple<decimal, decimal>(valorComPlano, valorSemPlano);
        }
    }
}
