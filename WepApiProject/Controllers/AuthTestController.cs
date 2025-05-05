using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiProject.Common;
using WepApiProject.DataContext;
using WepApiProject.Model;

namespace WepApiProject.Controllers
{
    public class AuthTestController : StoreController
    {
        public AuthTestController(AppDbContext context) : base(context)
        {
        }

        [HttpGet]
        public IActionResult Test1()
        {
            return Ok(new ResponceServer
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = "Test1: для всех"
            });
        }

        [HttpGet]
        [Authorize]
        public IActionResult Test2()
        {
            return Ok(new ResponceServer
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = "Test2: для авторизованных пользователей"
            });
        }

        [HttpGet]
        [Authorize(Roles = SharedData.Roles.Consumer)]
        public IActionResult Test3()
        {
            return Ok(new ResponceServer
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = "Test3: для авторизованных пользователей с правами Consumer"
            });
        }

        [HttpGet]
        [Authorize(Roles = SharedData.Roles.Admin)]
        public IActionResult Test4()
        {
            return Ok(new ResponceServer
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = "Test4: для авторизованных пользователей с правами Admin"
            });
        }
    }
}
