using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyAPI.Dto
{
    public class RegistratedHospitalDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ApiKey { get; set; }

        public RegistratedHospitalDto() { }

        public RegistratedHospitalDto(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public RegistratedHospitalDto(string name, string url, string apiKey)
        {
            this.Name = name;
            this.Url = url;
            this.ApiKey = apiKey;
        }
    }
}
