using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfringementAnalyser.Models
{

    public class Properties
    {
        public int action { get; set; }
        public bool includeHtml { get; set; }
        public Webhooks webhooks { get; set; }
    }

    public class URLScanRequestModel
    {
        public string url { get; set; }
        public Properties properties { get; set; }
    }

    public class Scanning
    {
        public bool internet { get; set; }
    }

    public class Webhooks
    {
        public string newResult { get; set; }
        public string status { get; set; }
    }


}
