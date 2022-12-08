using AutoMapper;
using MostreOCodigo.App.ViewModels;
using MostreOCodigo.Domain.Models;

namespace MostreOCodigo.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Valor, ValorViewModel>().ReverseMap();
        }
    }
}
