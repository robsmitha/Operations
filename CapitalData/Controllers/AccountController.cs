﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services;
using Domain.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapitalData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IApiService _api;

        public AccountController(ILogger<AccountController> logger, IApiService api)
        {
            _logger = logger;
            _api = api;
        }

        [HttpPost("SignIn")]
        public async Task<UserModel> SignIn(UserModel data)
        {
            var user = await _api.GetAsync<UserModel>($"/users/getbyusername/{data.Username}");
            if (!string.IsNullOrEmpty(data?.Password) && SecurePasswordHasher.Verify(data.Password, user.Password))
            {
                return user;
            }
            return data;
        }
        [HttpGet("Profile/{id}")]
        public async Task<UserModel> Profile(int id)
        {
            var user = await _api.GetAsync<UserModel>($"/users/{id}");
            if(user != null)
            {
                return user;
            }
            return new UserModel();
        }
    }
}