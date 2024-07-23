using KnowMeService.DTOs;
using KnowMeService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KnowMeAPI
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public string TestMethod()
        {
            return "We got message";
        }

        [HttpPost("CreateUser")]
        public async Task<IResult> CreateUser(CreateUserDTO createUserDTO, HttpContext httpContext) 
        {
            var claimType = "sub";
            var claimValue = httpContext.User.FindFirstValue(claimType);
            try
            {
               await _userService.CreateUserAsync(createUserDTO, claimValue);
            }
            catch (Exception ex)
            {
                return Results.BadRequest("Something went wrong");
            }
            return Results.Ok();
        }

        public IActionResult EditUser()
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteUser()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetUser()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
