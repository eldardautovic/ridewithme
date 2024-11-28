using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoznjeController : BaseCRUDController<Voznje, VoznjeSearchObject, VoznjeInsertRequest, VoznjeUpdateRequest>
    {
        public VoznjeController(IVoznjeService service) : base(service) {
            _service = service;
        }
    }
}
