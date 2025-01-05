using Microsoft.AspNetCore.Authorization;
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
    public class KorisniciController : BaseCRUDController<Model.Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
        public KorisniciController(IKorisniciService service) : base(service) { }

        [HttpPost("login")]
        [AllowAnonymous]
        public Model.Korisnici Login(string username, string password)
        {
            return (_service as IKorisniciService).Login(username, password);
        }

        [HttpPost]
        [AllowAnonymous]
        public override Korisnici Insert(KorisniciInsertRequest request)
        {
            return base.Insert(request);
        }

    }
}
