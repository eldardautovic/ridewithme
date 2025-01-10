using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoviController : BaseCRUDController<Model.Gradovi, GradoviSearchObject, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviController(IGradoviService service) : base(service)
        {
        }
    }
}
