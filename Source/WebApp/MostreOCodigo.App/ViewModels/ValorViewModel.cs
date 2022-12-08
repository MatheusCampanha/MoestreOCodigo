using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MostreOCodigo.App.ViewModels
{
    public class ValorViewModel
    {
        [Key]
        public int ValorId { get; private set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [MaxLength(3, ErrorMessage = "Campo {0} deve conter no máximo 3 caracteres")]
        public string Origem { get; private set; } = default!;

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [MaxLength(3, ErrorMessage = "Campo {0} deve conter no máximo 3 caracteres")]
        public string Destino { get; private set; } = default!;

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [DisplayName("Valor")]
        public decimal ValorMinuto { get; private set; }
    }
}
