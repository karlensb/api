using ApiSegura.Models;
using System.Net;
using System.Threading;
using System.Web.Http;
using System.IO;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http;


namespace ApiSegura.Controllers
{
    /// <summary>
    /// login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

 
             string json;
            string path = AppDomain.CurrentDomain.BaseDirectory + "UsuarioValido.json";
            var User = new Models.LoginRequest();
            using (StreamReader jsonStream = File.OpenText(path))
            {
                json = jsonStream.ReadToEnd();
            }
            User = JsonConvert.DeserializeObject<Models.LoginRequest>(json);

           
            bool isCredentialValid = (login.Password == User.Password.ToString() && login.Username == User.Username.ToString());
            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
