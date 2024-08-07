using AppWebApiEstudo.Domain.Entity;

namespace AppWebApiEstudo.Domain.Interfaces
{
    public interface IBeneficiarioRepository
    {
        Task<IEnumerable<Beneficiario>> GetBeneficiarios();
        Task<Beneficiario> GetById(int? id);

        Task<Beneficiario> Create(Beneficiario beneficiario);
        Task<Beneficiario> Update(Beneficiario beneficiario);
        Task<Beneficiario> Remove(Beneficiario beneficiario);
    }
}
