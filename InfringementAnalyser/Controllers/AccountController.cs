using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfringementAnalyser.Interfaces.Interfaces;
using InfringementAnalyser.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfringementAnalyser.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet]
        public async Task<AuthenticationResponseModel> login()
        {
            var result = await this._authenticationService.GetToken();
            return result;
        }
    }
}