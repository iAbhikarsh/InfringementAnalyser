using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfringementAnalyser.Models
{
    public class AuthenticationRequestModel
    {
        public string email { get; set; }
        public string key { get; set; }
    }

    public class AuthenticationResponseModel
    {
        public string access_token { get; set; }
        [JsonProperty(".expires")]
        public DateTime expires { get; set; }
        [JsonProperty(".issued")]
        public DateTime issued { get; set; }
    }
}
