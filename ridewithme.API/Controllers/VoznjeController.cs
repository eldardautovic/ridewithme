using Azure.Core;
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
    public class VoznjeController : BaseCRUDController<Voznje, VoznjeSearchObject, VoznjeInsertRequest, VoznjeUpdateRequest>
    {
        public VoznjeController(IVoznjeService service) : base(service) {
            _service = service;
        }

        [HttpPut("{id}/activate")]

        public Model.Voznje Activate(int id)
        {
            return (_service as IVoznjeService).Activate(id);
        }

        [HttpPut("{id}/book")]

        public Model.Voznje Book(int id, VoznjeBookRequest request)
        {
            if (request.KlijentId == null || request.KlijentId == 0)
            {
                var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                request.KlijentId = userId;
            }

            return (_service as IVoznjeService).Book(id, request);
        }

        [HttpPut("{id}/edit")]

        public Model.Voznje Edit(int id)
        {
            return (_service as IVoznjeService).Edit(id);
        }

        [HttpPut("{id}/hide")]

        public Model.Voznje Hide(int id)
        {
            return (_service as IVoznjeService).Hide(id);
        }

        [HttpGet("{id}/allowedActions")]

        public List<string> AllowedActions(int id)
        {
            return (_service as IVoznjeService).AllowedActions(id);
        }

        [HttpDelete("{id}/delete")]

        public Model.Voznje Delete (int id)
        {
            return (_service as IVoznjeService).Delete(id);
        }

        [HttpPut("{id}/rate")]

        public Model.Voznje Rate(int id, int ocjena)
        {
            return (_service as IVoznjeService).Rate(id, ocjena);
        }

        [HttpGet("{id}/getParticipants")]

        public List<Korisnici> GetParticipants(int id)
        {
            return (_service as IVoznjeService).GetParticipants(id);
        }

        public override Voznje Insert(VoznjeInsertRequest request)
        {
            if(request.VozacId == null || request.VozacId == 0)
            {
                var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                request.VozacId = userId;
            }

            return base.Insert(request);
        }

        public override Voznje Update(int id, VoznjeUpdateRequest request)
        {
            if (request.VozacId == null || request.VozacId == 0)
            {
                var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                request.VozacId = userId;
            }
            return base.Update(id, request);
        }
    }
}
