using Microsoft.AspNetCore.Mvc;

namespace HomelyPopup.AspNetCore.Controllers
{
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        // GET api/orders?customerName="Ryan"
        [HttpGet]
        public string Get(string customerName)
        {
            return "TODO";
        }
    }
}
