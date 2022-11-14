using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InfringementAnalyser.Interfaces.Interfaces
{
    public interface IScanService
    {
        Task<HttpResponseMessage> SubmitScanByURL(string url, string scanId);
        Task<HttpResponseMessage> SubmitScanByFile(string filename, string scanId, string base64);
    }
}
