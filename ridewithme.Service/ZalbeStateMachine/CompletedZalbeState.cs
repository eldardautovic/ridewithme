﻿using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Mapster;
using Azure.Core;

namespace ridewithme.Service.ZalbeStateMachine
{
    public class CompletedZalbeState : BaseZalbeState
    {
        ILogger<CompletedZalbeState> _logger;
        public CompletedZalbeState(Database.RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider, ILogger<CompletedZalbeState> logger) : base(dbContext, mapper, serviceProvider)
        {
            _logger = logger;
        }

        public override string Delete(int id)
        {
            var set = Context.Set<Database.Zalbe>();

            var entity = set.Find(id);

            if (entity == null)
            {
                throw new UserException("Zalba sa tim ID-om ne postoji.");
            }

            set.Remove(entity);

            Context.SaveChanges();

            _logger.LogInformation($"[-] Zalba ID: {id} je obrisana od strane administratora.");

            return "Zalba je uspjesno obrisana.";
        }

        public override List<string> AllowedActions(Database.Zalbe entity)
        {
            return new List<string>() { nameof(Delete) };
        }
    }
}