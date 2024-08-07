using AppWebApiEstudo.Application.DTOs;
using AppWebApiEstudo.Domain.Entity;
using AutoMapper;

namespace AppWebApiEstudo.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {     
        public DomainToDTOMappingProfile()
        {
            CreateMap<Beneficiario, BeneficiarioDTO>().ReverseMap();
        }

    }
}
