﻿using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IZalbeService : ICRUDService<Zalbe, ZalbeSearchObject, ZalbeInsertRequest, ZalbeUpdateRequest>
    {
        public Zalbe Processing(int id, int administratorId);

        public Zalbe Activate(int id);

        public Zalbe Complete(int id, ZalbeCompleteRequest request);

        public string Delete(int id);
        public List<string> AllowedActions(int id);

    }
}