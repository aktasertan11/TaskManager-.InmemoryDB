using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace hafta1WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        

       [HttpGet]

       public ActionResult<List<string>> Get()
        {
            return Ok(Status.getStatus());
        }
    }
}
