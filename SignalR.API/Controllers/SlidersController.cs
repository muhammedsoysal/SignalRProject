using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _slidersService;

        public SlidersController(ISliderService slidersService)
        {
            _slidersService = slidersService;
        }
        [HttpGet]
        public ActionResult SliderList()
        {
            return Ok(_slidersService.TGetListAll());
        }
    }
}
