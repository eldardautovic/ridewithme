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
    public class KuponiController : BaseCRUDController<Model.Kuponi, KuponiSearchObject, KuponiInsertRequest, KuponiUpdateRequest>
    {
        public KuponiController(IKuponiService service) : base(service)
        {
        }
        
        [Authorize(Roles = "Administrator")]
        public override Kuponi Insert(KuponiInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        public override Kuponi Update(int id, KuponiUpdateRequest request)
        {
            return base.Update(id, request);
        }

        [HttpPut("{id}/activate")]

        public Model.Kuponi Activate(int id)
        {
            return (_service as IKuponiService).Activate(id);
        }

        [HttpPut("{id}/hide")]

        public Model.Kuponi Hide(int id)
        {
            return (_service as IKuponiService).Hide(id);
        }

        [HttpPut("{id}/edit")]

        public Model.Kuponi Edit(int id)
        {
            return (_service as IKuponiService).Edit(id);
        }


        [HttpGet("{id}/allowedActions")]

        public List<string> AllowedActions(int id)
        {
            return (_service as IKuponiService).AllowedActions(id);
        }
    }
}
