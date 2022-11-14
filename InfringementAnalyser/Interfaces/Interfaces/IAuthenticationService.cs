using InfringementAnalyser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfringementAnalyser.Interfaces.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponseModel> GetToken();
    }
}
