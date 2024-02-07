using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Models
{
    public class APIResponse
    {

        public APIResponse()
        {
            this.ErrorMesages = new List<string>();
        }

        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccess { get; set; } = true;

        public List<string> ErrorMesages { get; set; }

        public object Result { get; set; }
    }
}