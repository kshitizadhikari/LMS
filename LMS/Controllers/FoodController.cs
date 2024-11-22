using LMS.Core.DTOs.FoodDTOs;
using LMS.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    public class FoodController : BaseApiController
    {
        private readonly IServiceWrapper _services;

        public FoodController(IServiceWrapper services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodById(string id)
        {
            FoodDTO result = await _services.FoodService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            List<FoodDTO> result = await _services.FoodService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFood([FromBody] FoodDTO dto)
        {
            FoodDTO result = await _services.FoodService.CreateAsync(dto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFood(FoodDTO dto)
        {
            FoodDTO result = await _services.FoodService.UpdateAsync(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(string id)
        {
            await _services.FoodService.DeleteAsync(id);
            return Ok();
        }
    }
}
