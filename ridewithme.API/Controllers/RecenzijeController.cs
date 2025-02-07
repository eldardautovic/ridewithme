using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecenzijeController : BaseCRUDController<Model.Recenzija, RecenzijaSearchObject, RecenzijaUpsertRequest, RecenzijaUpsertRequest>
    {
        public RecenzijeController(IRecenzijaService service) : base(service)
        {
        }
    }
}
