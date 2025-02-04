﻿using Microsoft.AspNetCore.Authorization;
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
    public class VrstaZalbeController : BaseCRUDController<Model.VrstaZalbe, VrstaZalbeSearchObject, VrstaZalbeInsertRequest, VrstaZalbeUpdateRequest>
    { 
        public VrstaZalbeController(IVrstaZalbeService service) : base(service)
        {
        }

        [Authorize(Roles = "Administrator")]
        public override VrstaZalbe Insert(VrstaZalbeInsertRequest request)
        {
            if (request.KorisnikId == null || request.KorisnikId == 0)
            {
                var userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                request.KorisnikId = userId;
            }

            return base.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        public override PagedResult<VrstaZalbe> GetList([FromQuery] VrstaZalbeSearchObject searchObject)
        {
            return base.GetList(searchObject);
        }
    }
}
