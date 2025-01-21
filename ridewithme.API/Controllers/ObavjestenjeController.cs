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
    public class ObavjestenjeController : BaseCRUDController<Model.Obavjestenja, ObavjestenjaSearchObject, ObavjestenjaInsertRequest, ObavjestenjaUpdateRequest>
    {
        public ObavjestenjeController(IObavjestenjaService service) : base(service)
        {
        }

        [AllowAnonymous]
        public override PagedResult<Obavjestenja> GetList([FromQuery] ObavjestenjaSearchObject searchObject)
        {
            return base.GetList(searchObject);
        }

        [HttpPut("{id}/activate")]

        public Model.Obavjestenja Activate(int id)
        {
            return (_service as IObavjestenjaService).Activate(id);
        }

        [HttpPut("{id}/complete")]

        public Model.Obavjestenja Complete(int id)
        {
            return (_service as IObavjestenjaService).Complete(id);
        }

        [HttpPut("{id}/edit")]

        public Model.Obavjestenja Edit(int id)
        {
            return (_service as IObavjestenjaService).Edit(id);
        }

        [HttpPut("{id}/hide")]

        public Model.Obavjestenja Hide(int id)
        {
            return (_service as IObavjestenjaService).Hide(id);
        }

        [HttpGet("{id}/allowedActions")]

        public List<string> AllowedActions(int id)
        {
            return (_service as IObavjestenjaService).AllowedActions(id);
        }
    }
}
