using Exploritas.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Exploritas.API.V1
{
    [ApiVersion("1.0", Deprecated = false)]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CotasController: ControllerBase
    {

        private readonly ICotaService _cotaService;

        public CotasController(ICotaService cotaService)
        {
            _cotaService = cotaService;
        }

        [HttpGet]
        public async Task<ActionResult> Buscar()
        {

            var cotas = await _cotaService.ObterPorData(DateTime.Today);
            return Ok(cotas);
        }
    }
}
