using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InfringementAnalyser.Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InfringementAnalyser.Controllers
{
    public class ScansController : Controller
    {
        private readonly IScanService _scanSvc;

        public ScansController(IScanService scanSvc)
        {
            _scanSvc = scanSvc;
        }

        [HttpGet]
        [Route("URL")]
        public async Task<HttpResponseMessage> SubmitScanByURL([FromQuery] string url, [FromQuery] string scanId)
        {
            var result = await this._scanSvc.SubmitScanByURL(url, scanId);
            return result;
        }

        [HttpGet]
        [Route("file")]
        public async Task<HttpResponseMessage> SubmitScanByFile([FromQuery]string filename, [FromQuery] string scanId, [FromQuery] string base64)
        {
            var result = await this._scanSvc.SubmitScanByFile(filename, scanId, base64);
            return result;
        }

    }
}