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
    public class ProvinciaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult add(Models.Request.ProvinciaRequest model)
        {
            string result = "No se encontro la provincia Buscada";
            string json;
            var provin = new Models.Request.ProvinciasJs();
            //WebRequest request = WebRequest.Create("https://apis.datos.gob.ar/georef/api/provincias");
            WebRequest request = WebRequest.Create("http://localhost:53989/api/ApiExternaPublic");
            request.Method = "GET";
            request.PreAuthenticate = true;
            request.ContentType = "application/json;charset=utf-8'";
            request.Timeout = 10000;
           
            try{
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))              
                    {
                        json = streamReader.ReadToEnd();
                        provin = JsonConvert.DeserializeObject<Models.Request.ProvinciasJs>(json);
                        foreach (var prov in provin.provincias)
                        {
                            if (prov.nombre.ToString() == model.ProvinciaABuscar.ToString())
                            {
                                result = "la Provincia " + prov.nombre.ToString() + " tiene  Lat " + prov.centroide.lat.ToString() + " y   Lon " + prov.centroide.lon.ToString();
                            }
                        }
                }
                } catch (Exception e)
            {
                if (model == null) {
                    result = "No se ha recibido el parametro ProvinciaABuscar ";
                }
                    result = result  + "ERROR " + e.ToString();
                ManagerErrors.LogErrror m = new ManagerErrors.LogErrror();
                m.Log(result);

            }
            return Ok(result);
        }
}
}
