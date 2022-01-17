using _77Diamonds.Common;
using _77Diamonds.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _77Diamonds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly ICacheHelper _cacheHelper;
        private readonly IMasterTableService _masterTableService;

        public MasterController(ICacheHelper cacheHelper, IMasterTableService masterTableService)
        {
            _cacheHelper = cacheHelper;
            _masterTableService = masterTableService;
        }
        [HttpGet("GetColors")]
        public IActionResult GetColors()
        {
            return new JsonResult(_cacheHelper.GetColors());
        }
        [HttpGet("GetFabrics")]
        public IActionResult GetFabrics()
        {
            return new JsonResult(_cacheHelper.GetFabrics());
        }
    }
}
