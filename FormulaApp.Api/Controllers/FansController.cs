using FormulaApp.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.Api.Controllers
{
    [Route("api/fans")]
    [ApiController]
    public class FansController : ControllerBase
    {
        private readonly IFansService _fansService;

        public FansController(IFansService fansService)
        {
            _fansService = fansService;
        }

        [HttpGet("get-fans")]
        public async Task<IActionResult> GetFans()
        {
            var fans = await _fansService.GetAllFans();
            return Ok(fans);
        }
    }
}
