using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationClassLib.Parthership.Model
{
    public class Objection
    {

        public string Id { get; set; }
        public string PharmacyName { get; set; }
        public string TextObjection { get; set; }

        public Objection() { Id = "0"; }

        public Objection(string text, string name) {

            Id = "0";
            TextObjection = text;
            PharmacyName = name;
            
        }


    }
}
