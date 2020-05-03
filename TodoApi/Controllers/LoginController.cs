using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using TodoApi.Models;

namespace TodoApi.Controllers
{
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

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
            {
                return NotFound();
            }

            if (login.DocumentID == "1118310488" && login.Code == "011720116" && login.Password == "1234567890")
            {
                ResponseDTO responseDTO = new ResponseDTO
                {
                    Exitoso = 1
                };

                return Ok(responseDTO);
            }
            else
            {
                ResponseDTO responseDTO = new ResponseDTO
                {
                    Exitoso = 0
                };

                return Ok(responseDTO);
            }
        }
    }
}