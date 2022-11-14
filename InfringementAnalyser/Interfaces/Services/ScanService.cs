using InfringementAnalyser.Interfaces.Interfaces;
using InfringementAnalyser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InfringementAnalyser.Interfaces.Services
{
    public class ScanService:IScanService
    {
        private readonly IAuthenticationService _authSvc;
        string baseUrl = "https://api.copyleaks.com/v3/scans/submit";
        public ScanService(IAuthenticationService authSvc)
        {
            _authSvc = authSvc;
        }

        public async Task<HttpResponseMessage> SubmitScanByFile(string filename, string scanId, string base64)
        {
            var token = await _authSvc.GetToken();
            var data = JsonConvert.SerializeObject(new FileScanRequestModel
            {
                base64 = base64,
                properties = new Properties
                {
                    action = 0,
                    includeHtml = true,
                    webhooks = new Webhooks
                    {
                        status = "https://enh72awz76q89.x.pipedream.net/{STATUS}/scanId"
                    }
                    //Add pdf create property
                },
                fileName = filename

            });


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), baseUrl + "/url/" + scanId))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", token.access_token);

                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await httpClient.SendAsync(request);
                    return response;
                }
            }
        }

        public async Task<HttpResponseMessage> SubmitScanByURL(string url, string scanId)
        {
            var token = await _authSvc.GetToken();
            var data = JsonConvert.SerializeObject(new URLScanRequestModel
            {
                url = url,
                properties = new Properties
                {
                    action = 0,
                    includeHtml = true,
                    webhooks = new Webhooks
                    {
                        status = "https://enh72awz76q89.x.pipedream.net/webhook/{STATUS}/" + scanId
                    },
                    //TODO: Add pdf create property

                }

            });


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), baseUrl + "/url/" + scanId))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token.access_token);

                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await httpClient.SendAsync(request);
                    return response;
                }
            }

        }
    }
}
