using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyAPI.Dto
{
    public class ObjectionDTO
    {
        public long Id { get; set; }
        public string PharmacyName { get; set; }
        public string TextObjection { get; set; }

        public ObjectionDTO() { }

        public ObjectionDTO(string text, string name)
        {

            TextObjection = text;
            PharmacyName = name;

        }
    }
}
