using IntegrationAPI.Dto;
using IntegrationClassLib.Parthership.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPI.Mapper
{
    public class ObjectionMapper
    {
        public static Objection ObjectionDTOToObjection(ObjectionDTO objection) {
            return new Objection(objection.PharmacyName, objection.TextObjection);
        }

        public static ObjectionDTO ObjectionToObjectionDTO(Objection objection) {
            return new ObjectionDTO (objection.TextObjection, objection.PharmacyName);
        }

    }
}
