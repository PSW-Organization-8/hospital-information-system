using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPI.Dto
{
    public class PharmacyDto
    {
        public string Name { get; set; }

        public String ApiKey { get; set; }

        public String Url { get; set; }

        public String Port { get; set; }

        public PharmacyDto() { }

        public PharmacyDto(string name, string apiKey, string url, string port)
        {
            Name = name;
            ApiKey = apiKey;
            Url = url;
            Port = port;
        }
    }
}
