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
    public class UlogeController : BaseCRUDController<Model.Uloge, UlogeSearchObject, UlogeUpsertRequest, UlogeUpsertRequest>
    {
        public UlogeController(IUlogeService service) : base(service)
        {
        }
    }
}
