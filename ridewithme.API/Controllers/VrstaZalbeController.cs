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
    public class VrstaZalbeController : BaseCRUDController<Model.VrstaZalbe, VrstaZalbeSearchObject, VrstaZalbeInsertRequest, VrstaZalbeUpdateRequest>
    { 
        public VrstaZalbeController(IVrstaZalbeService service) : base(service)
        {
        }

        [AllowAnonymous]
        public override VrstaZalbe Insert(VrstaZalbeInsertRequest request)
        {
            return base.Insert(request);
        }

        [AllowAnonymous]
        public override PagedResult<VrstaZalbe> GetList([FromQuery] VrstaZalbeSearchObject searchObject)
        {
            return base.GetList(searchObject);
        }
    }
}
