using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;
using System.Security.Claims;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReklameController : BaseCRUDController<Model.Reklame, ReklameSearchObject, ReklameUpsertRequest, ReklameUpsertRequest>
    {
        public ReklameController(IReklameService service) : base(service)
        {
        }

        [Authorize(Roles = "Administrator")]
        public override Reklame Insert(ReklameUpsertRequest request)
        {
            var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            request.KorisnikId = userId; 

            return base.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        public override Reklame Update(int id, ReklameUpsertRequest request)
        {
            return base.Update(id, request);
        }

        [AllowAnonymous]
        public override PagedResult<Reklame> GetList([FromQuery] ReklameSearchObject searchObject)
        {
            return base.GetList(searchObject);
        }
    }
}
