using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;

namespace ApiKar.Controllers
{
    public class ApiExternaPublicController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetProv()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "provincia.json";
            var provin = new Models.Request.ProvinciasJs();
            string result = "Exito";
            string json;
            try
            {
                using (StreamReader jsonStream = File.OpenText(path))
                {
                    json = jsonStream.ReadToEnd();
                }
                provin = JsonConvert.DeserializeObject<Models.Request.ProvinciasJs>(json);
            }
            catch (Exception e)
            {
                result = "ERROR " + e.ToString();
            }
            return Ok( provin);

        }
    }
}
