using AppWebApiEstudo.Application.DTOs;
using AppWebApiEstudo.Application.Services.Interfaces;
using AppWebApiEstudo.Domain.Entity;
using AppWebApiEstudo.Domain.Interfaces;
using AutoMapper;

namespace AppWebApiEstudo.Application.Services
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;
        private readonly IMapper _mapper;

        public BeneficiarioService(IBeneficiarioRepository beneficiarioRepository, IMapper mapper)
        {
            _mapper = mapper;
            _beneficiarioRepository = beneficiarioRepository;
        }
        public async Task Add(BeneficiarioDTO beneficiarioDto)
        {
            var beneficiarioEntity = _mapper.Map<Beneficiario>(beneficiarioDto);
            await _beneficiarioRepository.Create(beneficiarioEntity);
            beneficiarioDto.Id = beneficiarioEntity.Id;
        }

        public async Task<BeneficiarioDTO> GetById(int? id)
        {
            var beneficiarioEntity = await _beneficiarioRepository.GetById(id);
            return _mapper.Map<BeneficiarioDTO>(beneficiarioEntity);
        }

        public async Task<IEnumerable<BeneficiarioDTO>> GetBeneficiarios()
        {
            var beneficiarioEntity = await _beneficiarioRepository.GetBeneficiarios();
            return _mapper.Map<IEnumerable<BeneficiarioDTO>>(beneficiarioEntity);
        }

        public async Task Remove(int? id)
        {
            var beneficiarioEntity = _beneficiarioRepository.GetById(id).Result;
            await _beneficiarioRepository.Remove(beneficiarioEntity);
        }

        public async Task Update(BeneficiarioDTO beneficiarioDto)
        {
            var beneficiarioEntity = _mapper.Map<Beneficiario>(beneficiarioDto);
            await _beneficiarioRepository.Update(beneficiarioEntity);
        }
    }
}
