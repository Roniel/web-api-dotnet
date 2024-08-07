using AppWebApiEstudo.Application.DTOs;
using AppWebApiEstudo.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppWebApiEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioService _beneficiarioService;
        public BeneficiarioController(IBeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BeneficiarioDTO>>> GetAll()
        {
           var beneficiarios =  await _beneficiarioService.GetBeneficiarios();
            return Ok(beneficiarios);
        }

        [HttpGet("id")]
        public async Task<ActionResult<BeneficiarioDTO>> Get(int? id)
        {
            var beneficiario = await _beneficiarioService.GetById(id);
            return Ok(beneficiario);
        }
    }
}
