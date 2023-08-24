using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Scheduler.Controller;
using Microsoft.AspNetCore.Mvc;

namespace stj1_Amir_Departman_Proje_Bulma.Schedulers.Controller
{
    [Route("apps/stj1_Amir_Departman_Proje_Bulma/latest/api/Scheduler/[action]")]
    [Route("apps/stj1_Amir_Departman_Proje_Bulma/{v:int:min(1)}/api/Scheduler/[action]")]
    [Route("api/Scheduler/[action]")]
    [Produces("application/json")]
    public class SchedulerController : BaseSchedulerController
    {
        public SchedulerController(IIocManager iocManager) : base(iocManager)
        {
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Scheduler API Controller is ok";
        }
    }
}