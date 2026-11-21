using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
   
    [ApiController]
    public class RestaurantController(MapDbContext db) : ControllerBase
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List()
        {
            
        }
    }
}
