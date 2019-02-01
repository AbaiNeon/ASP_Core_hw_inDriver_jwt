using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_hw_inDriver_jwt.Data;
using ASP_hw_inDriver_jwt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_hw_inDriver_jwt.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {
        private readonly Context _db;

        public TaxiController(Context context)
        {
            _db = context;
        }

        // POST api/Taxi/MakeOrder
        [HttpPost]
        public async Task<IActionResult> MakeOrder([FromBody] Order order)
        {
            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            return Ok(order);
        }

        // GET api/Taxi/GetUnhandledOrders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetUnhandledOrders()
        {
            return _db.Orders.Where(i => i.ExecutionStatus == false).ToList();
        }

        // GET api/Taxi/TakeOrder/1
        public Order TakeOrder(int id)
        {
            return _db.Orders.Single(i => i.Id == id);
        }

    }
}