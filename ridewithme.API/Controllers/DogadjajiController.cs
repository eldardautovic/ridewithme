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
    [Authorize(Roles = "Administrator")]
    public class DogadjajiController : BaseCRUDController<Model.Dogadjaji, DogadjajiSearchObejct, DogadjajiUpsertRequest, DogadjajiUpsertRequest>
    {
        public DogadjajiController(IDogadjaji service) : base(service)
        {
        }

        [AllowAnonymous]
        public override PagedResult<Dogadjaji> GetList([FromQuery] DogadjajiSearchObejct searchObject)
        {
            return base.GetList(searchObject);
        }
    }
}
