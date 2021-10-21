using Exploritas.Application.ViewModels;
using Exploritas.Domain.Entities;

namespace Exploritas.Infrastructure.Mappers
{
    public class CotaMappingProfile : MappingProfile
    {

        public CotaMappingProfile()
        {
            CreateMap<CotaViewModel, Cota>().ReverseMap();

        }
    }
}
