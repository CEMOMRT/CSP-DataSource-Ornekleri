using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace stj1_Amir_Departman_Proje_Bulma.Forms
{
    [Route("apps/stj1_Amir_Departman_Proje_Bulma/latest/api/Form2/[action]")]
    [Route("apps/stj1_Amir_Departman_Proje_Bulma/{v:int:min(1)}/api/Form2/[action]")]
    [Route("api/Form2/[action]")]
    [Produces("application/json")]
    public class Form2Controller : BaseFormController<Form2>
    {
        public Form2Controller(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Form2 API Controller is ok";            
        }
    }
}