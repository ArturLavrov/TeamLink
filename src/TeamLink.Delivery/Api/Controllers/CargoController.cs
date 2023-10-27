using Microsoft.AspNetCore.Mvc;
using TeamLink.Delivery.Api.Dto;
using TeamLink.Delivery.Services;

namespace TeamLink.Delivery.Api.Controllers
{
    [ApiController]
    [Route("delivery/api/[controller]")]
    [ApiExplorerSettings(GroupName = "delivery")]
    public class CargoController : ControllerBase
    {
        private readonly ICargoTrackingService _cargoTrackingService;
        
        public CargoController(ICargoTrackingService cargoTrackingService)
        {
            _cargoTrackingService = cargoTrackingService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<CargoDto>> GetCargoById(string id)
        {
            await Task.Delay(300);
            return Ok(new CargoDto()
            {
                Status = _cargoTrackingService.GetCargoStatus(id)
            });
        }
    }
}
