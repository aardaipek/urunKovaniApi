﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using urunKovaniApi.Helpers;
using urunKovaniApi.Models;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace urunKovaniApi.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IAuthOperation _authOperation;

        public UserController(UrunKovaniContext context, IAuthOperation authOperation)
        {
            _authOperation = authOperation;
        }

        [Route("register"), HttpPost]
        public async Task<ActionResult<Users>> Register([FromBody] JObject data)
        {
            var registerResponse = await _authOperation.Register(data);

            if (!registerResponse)
                return BadRequest();

            var registeredUser = await _authOperation.GetCurrentUser((string)data["email"]);

            if (registeredUser == null)
                return BadRequest();

            return registeredUser;
        }

        [Route("login"), HttpPost]
        public async Task<ActionResult<Users>> Login([FromBody] JObject data)
        {
            var loginResponse = await _authOperation.Login(data);

            if (!loginResponse)
                return BadRequest();

            var loggedUser = await _authOperation.GetCurrentUser((string)data["email"]);

            if(loggedUser == null)
                return BadRequest();

            return loggedUser;
           
        }

    }
}
