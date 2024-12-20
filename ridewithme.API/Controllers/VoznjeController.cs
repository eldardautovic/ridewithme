﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service;

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
    }
}
