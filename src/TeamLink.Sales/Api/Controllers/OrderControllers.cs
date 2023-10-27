using Microsoft.AspNetCore.Mvc;

namespace TeamLink.Sales.Api.Controllers
{
    [ApiController]
    [Route("sales/api/[controller]")]
    [ApiExplorerSettings(GroupName = "sales")]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {
            
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> Get(string id)
        {
            await Task.Delay(30);
            return Ok(new OrderDto()
            {
                Id = id,
                Status = "Completed"
            });
        }
    }
}

