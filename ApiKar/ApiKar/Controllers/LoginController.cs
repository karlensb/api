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
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(Models.ViewModel.LoginRequest login)
        {
            string json;
            string result = "";
            try {
                string path = AppDomain.CurrentDomain.BaseDirectory + "UsuarioValido.json";
                var User = new Models.ViewModel.LoginRequest();
                using (StreamReader jsonStream = File.OpenText(path))
                    {
                        json = jsonStream.ReadToEnd();
                    }
                User = JsonConvert.DeserializeObject<Models.ViewModel.LoginRequest>(json);
                bool isCredentialValid = (login.Password == User.Password.ToString() && login.Username == User.Username.ToString());

                if (isCredentialValid)
                {
                    return Ok("autorizado");
                }
                else
                {
                    return Unauthorized();
                }

            }
            catch (Exception e) {
                if (login == null)
                {
                    result = "No se ha recibido el parametro ProvinciaABuscar ";
                }
                ManagerErrors.LogErrror m = new ManagerErrors.LogErrror();
                m.Log(result + " Error " + e.ToString());
                return Unauthorized();

            }

        }

    }
}
