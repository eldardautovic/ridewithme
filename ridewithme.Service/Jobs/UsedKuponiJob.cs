using Microsoft.Extensions.Logging;
using Quartz;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.Jobs
{
    public class UsedKuponiJob : IJob
    {
        RidewithmeContext Context;
        ILogger<UsedKuponiJob> _logger;
        public UsedKuponiJob(RidewithmeContext dbContext, ILogger<UsedKuponiJob> logger)
        {
            Context = dbContext;
            _logger = logger;
        }
        public Task Execute(IJobExecutionContext context)
        {
            var results = Context.Kuponi.Where(x => x.BrojIskoristivosti == 0 && x.StateMachine != "used").ToList();

            foreach (var result in results)
            {
                result.StateMachine = "used";
            }

            Context.SaveChanges();

            _logger.LogInformation("[!!!] UsedKuponiJob CRON zavrsen.");


            return Task.CompletedTask;
        }
    }
}
