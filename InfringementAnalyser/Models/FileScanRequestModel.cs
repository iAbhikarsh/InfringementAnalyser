using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfringementAnalyser.Models
{
    public class FileScanRequestModel
    {
        public string base64 { get; set; }
        public string fileName { get; set; }
        public Properties properties;
    }
}
