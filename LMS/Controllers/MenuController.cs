using LMS.Core.DTOs.MenuDTOs;
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
        public async Task<MenuDTO> Create([FromBody] CreateMenuDTO dto)
        {
            MenuDTO result = await _services.MenuService.CreateAsync(dto);
            return result;
        }

    }
}
