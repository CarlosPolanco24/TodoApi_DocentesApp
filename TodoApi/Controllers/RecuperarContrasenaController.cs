using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TodoApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/recuperarcontrasena")]
    public class RecuperarContrasenaController : ApiController
    {
        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(RecuperarContrasenaRequest recuperarContrasena)
        {
            if (recuperarContrasena.Email.Contains("@") && recuperarContrasena.Email.Contains(".com") || recuperarContrasena.Email.Contains("@") && recuperarContrasena.Email.Contains(".co"))
            {
                ResponseContrasena responseContrasena = new ResponseContrasena
                {
                    Ok = 1
                };

                return Ok(responseContrasena);
            }
            else
            {
                ResponseContrasena responseContrasena = new ResponseContrasena
                {
                    Ok = 0
                };

                return Ok(responseContrasena);
            }

            //if (recuperarContrasena.Email == "carlos.polanco.0ds@utap.edu.co")
            //{
            //    ResponseDTO responseDTO = new ResponseDTO
            //    {
            //        Exitoso = 1
            //    };

            //    return Ok(responseDTO);
            //}
            //else
            //{
            //    ResponseDTO responseDTO = new ResponseDTO
            //    {
            //        Exitoso = 0
            //    };

            //    return Ok(responseDTO);
            //}
        }
    }
}
