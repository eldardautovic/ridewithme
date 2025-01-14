using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class UlogeController : BaseCRUDController<Model.Uloge, UlogeearchObject, UlogeUpsertRequest, UlogeUpsertRequest>
    {
        public UlogeController(IUlogeervice service) : base(service)
        {
        }
    }
}
