using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiExample.Controllers
{
    /*跨域3步骤
     * 1.使用nuget下载Microsoft.AspNet.WebApi.Cors
     * 2.在WebApiConfig中启用跨域， config.EnableCors();
     * 3.在控制器上配置EnableCors,*代表不做限制。
     */
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CrossController : ApiController
    {
        public string Get()
        {
            return "Hello WebApi";
        }
    }
}
