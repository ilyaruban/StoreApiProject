﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiProject.Common;
using WepApiProject.DataContext;
using WepApiProject.Model;
using WepApiProject.ModelDto;
using WepApiProject.Service;

namespace WepApiProject.Controllers
{
    public class AuthController : StoreController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtTokenGenerator jwtTokenGenerator;

        public AuthController(AppDbContext context, UserManager<AppUser> userManager,
                              RoleManager<IdentityRole> roleManager,
                              JwtTokenGenerator jwtTokenGenerator) : base(context)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this.jwtTokenGenerator = jwtTokenGenerator;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            if (registerRequestDto == null)
            {
                return BadRequest(new ResponceServer()
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Некорректная модель запроса" }
                });
            }

            var userFromDb = await Context.AppUsers.FirstOrDefaultAsync(p => p.UserName.ToLower() ==
            registerRequestDto.UserName.ToLower());

            if (userFromDb != null)
            {
                return BadRequest(new ResponceServer()
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Такой пользователь есть" }
                });
            }

            var newAppUser = new AppUser
            {
                UserName = registerRequestDto.UserName,
                Email = registerRequestDto.Email,
                NormalizedEmail = registerRequestDto.Email.ToUpper(),
                FirstName = registerRequestDto.UserName
            };

            var result = await _userManager.CreateAsync(newAppUser, registerRequestDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(new ResponceServer()
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Ошибка регистрации" }
                });
            }

            var newRoleAppUser = registerRequestDto.Role.Equals(
                SharedData.Roles.Admin, StringComparison.OrdinalIgnoreCase)
                ? SharedData.Roles.Admin : SharedData.Roles.Consumer;

            await _userManager.AddToRoleAsync(newAppUser, newRoleAppUser);

            return Ok(new ResponceServer()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = "Регистрация завершена"
            });
        }

        [HttpPost]
        public async Task<ActionResult<ResponceServer>> Login(
            [FromBody] LoginRequestDto loginRequestDto)
        {
            var userFromDb = await Context.AppUsers.FirstOrDefaultAsync(p => p.Email.ToLower() ==
            loginRequestDto.Email.ToLower());

            if (userFromDb == null || !await _userManager.CheckPasswordAsync(userFromDb, loginRequestDto.Password))
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Такого пользователя нет" }
                });
            }

            var roles = await _userManager.GetRolesAsync(userFromDb);
            var token = jwtTokenGenerator.GenerateJwtToken(userFromDb, roles);

            return Ok(new ResponceServer()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Result = new LoginResponceDto
                {
                    Email = userFromDb.Email,
                    Token = token,
                }
            });
        }
    }
}
