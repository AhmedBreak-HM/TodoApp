using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApp.BreakService;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoApp.Controllers
{
    public class HomeController : AbpController
    {
        private readonly IBreakService _breakService;

        public HomeController(IBreakService breakService)
        {
            _breakService = breakService;
        }
        public ActionResult Index()
        {
            _breakService.DoSomething();
            return Redirect("~/swagger");
        }
    }
}
