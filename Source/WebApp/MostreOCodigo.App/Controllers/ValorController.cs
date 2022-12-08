using Microsoft.AspNetCore.Mvc;
using MostreOCodigo.Domain.Repositories.Services;
using System.Text.Json;

namespace MostreOCodigo.App.Controllers
{
    public class ValorController : Controller
    {
        private readonly IValorServices _valorServices;

        public ValorController(IValorServices valorServices)
        {
            _valorServices = valorServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> CalcularValores(string origem, string destino, int tempo, int plano)
        {
            var result = await _valorServices.CalcularValores(origem, destino, tempo, plano);

            return Json(JsonSerializer.Serialize(result));
        }
    }
}
