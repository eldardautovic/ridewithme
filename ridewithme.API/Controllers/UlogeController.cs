using Microsoft.AspNetCore.Authorization;
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
    public class UlogeController : BaseCRUDController<Model.Uloge, UlogeearchObject, UlogeUpsertRequest, UlogeUpsertRequest>
    {
        public UlogeController(IUlogeervice service) : base(service)
        {
        }

        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]
        public override Uloge Insert(UlogeUpsertRequest request)
        {
            return base.Insert(request);
        }

        [AllowAnonymous]
        public override PagedResult<Uloge> GetList([FromQuery] UlogeearchObject searchObject)
        {
            return base.GetList(searchObject);
        }
    }
}
