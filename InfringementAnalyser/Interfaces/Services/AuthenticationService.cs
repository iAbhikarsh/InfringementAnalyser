using InfringementAnalyser.Interfaces.Interfaces;
using InfringementAnalyser.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InfringementAnalyser.Interfaces.Services
{
    public class AuthenticationService:IAuthenticationService
    {
        private readonly IConfiguration _config;

        public AuthenticationService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<AuthenticationResponseModel> GetToken()
        {
            var requestUrl = "https://id.copyleaks.com/v3/account/login/api";
            var authRequestModel = new AuthenticationRequestModel();
            authRequestModel.key = _config.GetValue<string>("ApiKey");
            authRequestModel.email = "iabhikarshsingh@gmail.com";

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), requestUrl))
                    {
                        var data = JsonConvert.SerializeObject(authRequestModel);
                        request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                        var response = await httpClient.SendAsync(request);
                        var result = response.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<AuthenticationResponseModel>(result);
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
