using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

namespace ridewithme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        protected IKorisniciService _service;
        public KorisniciController(IKorisniciService service) {
            _service = service;
        }
        [HttpGet]
        public PagedResult<Korisnici> GetList([FromQuery] KorisniciSearchObject searchObject)
        {
            return _service.GetList(searchObject);
        }

        [HttpPost]
        public Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
