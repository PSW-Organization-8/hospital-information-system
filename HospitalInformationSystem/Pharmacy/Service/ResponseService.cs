using PharmacyClassLib.Model;
using PharmacyClassLib.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Service
{
    public class ResponseService
    {
        private readonly IResponseRepository responseRepository;

        public ResponseService(IResponseRepository responseRepository)
        {
            this.responseRepository = responseRepository;
        }

        public Response Add(Response response)
        {
            return responseRepository.Create(response);
        }

        public List<Response> GetAll()
        {
            return responseRepository.GetAll();
        }
    }
}
