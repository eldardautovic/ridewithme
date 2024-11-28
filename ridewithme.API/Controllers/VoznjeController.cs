using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoznjeController : BaseController<Voznje, VoznjeSearchObject>
    {
        protected IVoznjeService _service;
        public VoznjeController(IVoznjeService service) : base(service) {
            _service = service;
        }
    }
}
