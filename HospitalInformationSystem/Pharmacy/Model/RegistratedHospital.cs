using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class RegistratedHospital
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ApiKey { get; set; }

        public RegistratedHospital() { }

        public RegistratedHospital(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public RegistratedHospital(string name, string url, string apiKey)
        {
            this.Name = name;
            this.Url = url;
            this.ApiKey = apiKey;
        }
    }
}
