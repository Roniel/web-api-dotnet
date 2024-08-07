using AppWebApiEstudo.Domain.Entity;
using AppWebApiEstudo.Domain.Interfaces;
using AppWebApiEstudo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AppWebApiEstudo.Infra.Data.Repositories
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        private ApplicationDbContext _beneficiarioContext;
        public BeneficiarioRepository(ApplicationDbContext applicationDbContext)
        {
            _beneficiarioContext = applicationDbContext;
        }

        public async Task<Beneficiario> Create(Beneficiario beneficiario)
        {
            _beneficiarioContext.Add(beneficiario);
            await _beneficiarioContext.SaveChangesAsync();
            return beneficiario;
        }

        public async Task<IEnumerable<Beneficiario>> GetBeneficiarios()
        {
            return await _beneficiarioContext.Beneficiarios.ToListAsync();
        }

        public async Task<Beneficiario> GetById(int? id)
        {
            return await _beneficiarioContext.Beneficiarios.FindAsync(id);
        }

        public async Task<Beneficiario> Remove(Beneficiario beneficiario)
        {
            _beneficiarioContext.Remove(beneficiario);
            await _beneficiarioContext.SaveChangesAsync();
            return beneficiario;
        }

        public async Task<Beneficiario> Update(Beneficiario beneficiario)
        {
            _beneficiarioContext.Update(beneficiario);
            await _beneficiarioContext.SaveChangesAsync();
            return beneficiario;
        }
    }
}
