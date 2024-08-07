using AppWebApiEstudo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWebApiEstudo.Application.Services.Interfaces
{
    public interface IBeneficiarioService
    {
        Task<IEnumerable<BeneficiarioDTO>> GetBeneficiarios();
        Task<BeneficiarioDTO> GetById(int? id);
        Task Add(BeneficiarioDTO beneficiarioDto);
        Task Update(BeneficiarioDTO beneficiarioDto);
        Task Remove(int? id);
    }
}
