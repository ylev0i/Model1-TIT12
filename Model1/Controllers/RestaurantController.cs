using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
    [ApiController]
    public class RestaurantController(MapDbContext db) : ControllerBase
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List(int pageNum = 1, int pageSize = 10,
            string? restaurantName = null, string? restaurantType = null)
        {
            var q = db.Restaurants.AsQueryable();
            if (!string.IsNullOrEmpty(restaurantName))
               q = q.Where(x => x.RestaurantName!.Contains(restaurantName));
            if (!string.IsNullOrEmpty(restaurantType))
                q = q.Where(x => x.RestaurantType == restaurantType);

            return ApiResult.Ok();
        }
    }
}
