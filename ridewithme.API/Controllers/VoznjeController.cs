using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoznjeController : ControllerBase
    {
        protected IVoznjeService _service;
        public VoznjeController(IVoznjeService service) {
            _service = service;
        }
        [HttpGet]
        public List<Voznje> GetList([FromQuery] VoznjeSearchObject searchObject)
        {
            return _service.GetList(searchObject);
        }
    }
}
