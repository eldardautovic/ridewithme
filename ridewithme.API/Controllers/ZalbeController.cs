using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;
using System.Security.Claims;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZalbeController : BaseCRUDController<Model.Zalbe, ZalbeSearchObject, ZalbeInsertRequest, ZalbeUpdateRequest>
    {
        public ZalbeController(IZalbeService service) : base(service)
        {
        }

        [HttpPut("{id}/process")]

        public Model.Zalbe Processing(int id)
        {
            var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            return (_service as IZalbeService).Processing(id, userId);
        }

        [HttpPut("{id}/activate")]

        public Model.Zalbe Activate(int id)
        {
            return (_service as IZalbeService).Activate(id);
        }

        [HttpPut("{id}/complete")]

        public Model.Zalbe Complete(int id, ZalbeCompleteRequest request)
        {
            return (_service as IZalbeService).Complete(id, request);
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            return (_service as IZalbeService).Delete(id);
        }

        [HttpGet("{id}/allowedActions")]

        public List<string> AllowedActions(int id)
        {
            return (_service as IZalbeService).AllowedActions(id);
        }

    }
}
