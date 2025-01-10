using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Parameters;
using LMS.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    public class MenuController : BaseApiController
    {
        private readonly IServiceWrapper _services;

        public MenuController(IServiceWrapper services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMenuDTO dto)
        {
            MenuDTO result = await _services.MenuService.CreateAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] IncludeQP? includeQP)
        {
            List<MenuDTO> result = await _services.MenuService.GetAllAsync(includeQP);
            return Ok(result);
        }
    }
}
