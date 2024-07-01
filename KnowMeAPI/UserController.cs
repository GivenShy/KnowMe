using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace KnowMeAPI
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpGet]
        [Authorize]
        public string TestMethod()
        {
            return "We got message";
        }
    }
}
