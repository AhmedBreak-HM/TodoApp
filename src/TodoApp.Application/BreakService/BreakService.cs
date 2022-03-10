using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoApp.BreakService
{
    //[ExposeServices(typeof(IBreakService))]
    public class BreakService : IBreakService
    {
        private readonly ILogger<BreakService> _logger;

        public BreakService(ILogger<BreakService> logger)
        {
            _logger = logger;
        }
        public void DoSomething()
        {
            _logger.LogInformation("From Break Service");
        }
    }
}
